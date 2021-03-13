using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Design_Patterns.Behavioral.Command
{

    /**
     * Command Design Pattern
    */

    public class CommandPatternApp
    {
        public CommandPatternApp()
        {
            // Add each command to the command history and you can undo all the commands
            // by just iterating over the history and hitting Undo

            List<IDeviceButton> commandsHistory = new List<IDeviceButton>();

            var phone = new MobilePhone();
            var turnOnCommand = new TurnOnDevice(phone);
            var turnOffCommand = new TurnOffDevice(phone);
            var turnOffButton = new MobileButton(turnOffCommand);
            var turnOnButton = new MobileButton(turnOnCommand);

            IncreaseVolume increaseVolumeCommand = new IncreaseVolume(phone);

            MobileButton increaseVolumeButton = new MobileButton(increaseVolumeCommand);

            DecreaseVolume decreaseVolumeCommand = new DecreaseVolume(phone);

            MobileButton decreaseVolumeButton = new MobileButton(decreaseVolumeCommand);

            turnOffButton.Press();
            turnOnButton.Press();
            turnOffButton.Press();
            //increaseVolumeButton.Press(); // Will throw exception
            turnOnButton.Press();
            increaseVolumeButton.Press();
            increaseVolumeButton.Press();
            decreaseVolumeButton.Press();

            // Example of undoing using array
            // Last two command
            commandsHistory.Add(increaseVolumeButton);
            commandsHistory.Add(decreaseVolumeButton);

            commandsHistory.ForEach(command =>
            {
                command.UndoPress();
            });
            // Done

            // Undo commands individualy

            //increaseVolumeButton.UndoPress();
            //decreaseVolumeButton.UndoPress();

        }

    }


    interface IMediaDevice
    {
        public void On();
        public void Off();
        public int IncreaseVolume();
        public int DecreaseVolume();
    }


    class MobilePhone : IMediaDevice
    {
        private int _volume;
        private bool _powerOn;

        public MobilePhone()
        {
            _volume = 0;
            _powerOn = false;
        }
        
        public int DecreaseVolume()
        {

            if (this._powerOn)
            {
                Console.WriteLine($"Volume Decreased to {--_volume}");
                return _volume;
            }
            else
            {
                throw new Exception("Device is turned off");
            }
            
        }

        public int IncreaseVolume()
        {
            if (this._powerOn)
            {
                Console.WriteLine($"Volume Increased to {++_volume}");
                return _volume;
            }
            else 
            {
                throw new Exception("Device is turned off");
            }
        }

        public void Off()
        {
            Console.WriteLine($"Turning off the device");
            _powerOn = false;
        }

        public void On()
        {
            Console.WriteLine($"Your device is turning on");
            _powerOn = true;
        }

    }

    interface ICommand
    {
        public void Execute();
        public void Undo();
    }

    class TurnOnDevice : ICommand
    {
        private readonly IMediaDevice _mediaDevice;
        public TurnOnDevice(IMediaDevice device)
        {
            _mediaDevice = device;
        }
        public void Execute()
        {
            _mediaDevice.On();
        }

        public void Undo()
        {
            _mediaDevice.Off();
        }
    }

    class TurnOffDevice: ICommand
    {
        private readonly IMediaDevice _mediaDevice;

        public TurnOffDevice(IMediaDevice device)
        {
            _mediaDevice = device;
        }

        public void Execute()
        {
            _mediaDevice.Off();
        }
        public void Undo()
        {
            _mediaDevice.On();
        }
    }

    class IncreaseVolume:ICommand
    {
        private readonly IMediaDevice _mediaDevice;
        public IncreaseVolume(IMediaDevice device)
        {
            _mediaDevice = device;
        }

        public void Execute()
        {
            _mediaDevice.IncreaseVolume();
        }

        public void Undo()
        {
            _mediaDevice.DecreaseVolume();
        }
    }

    class DecreaseVolume : ICommand
    {
        private readonly IMediaDevice _mediaDevice;
        public DecreaseVolume(IMediaDevice device)
        {
            _mediaDevice = device;
        }

        public void Execute()
        {
            _mediaDevice.DecreaseVolume();
        }

        public void Undo()
        {
            _mediaDevice.IncreaseVolume();
        }
    }


    interface IDeviceButton
    {
        public void Press();
        public void UndoPress();
    }


    class MobileButton:IDeviceButton
    {
        private readonly ICommand _command;
        public MobileButton(ICommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }

        public void UndoPress()
        {
            _command.Undo();
        }
    }


}
