using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibilityApp
    {
        /// <summary>
        /// Client
        /// </summary>
        public ChainOfResponsibilityApp()
        {
            IChain driverOne = new CarDriver();
            IChain driverTwo = new TruckDriver();

            driverOne.SetNextChainCouple(driverTwo);

            driverOne.Drive(new Vehicle(Vehicle.Types.Jet, "Boeing 747"));
            driverOne.Drive(new Vehicle(Vehicle.Types.Truck, "Volvo VNL 740"));

        }
    }


    class Vehicle
    {
        public enum Types {Car, Bus, Truck, Jet};
        public Types type;
        public string Name { get; }
        public Vehicle(Types vehicleType, string name)
        {
            this.type = vehicleType;
            this.Name = name;
        }
        
    }

    /// <summary>
    /// Chain
    /// </summary>
    interface IChain
    {
        public void SetNextChainCouple(IChain chain);
        // Do something
        public void Drive(Vehicle vehicle);
    }

    abstract class Driver: IChain
    {
        protected readonly Vehicle.Types canDrive;
        protected IChain nextInChain;

        protected Driver(Vehicle.Types canDrive)
        {
            this.canDrive = canDrive;
        }

        virtual public void Drive(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        virtual public void SetNextChainCouple(IChain chain)
        {
            throw new NotImplementedException();
        }
    }

    class CarDriver : Driver
    {
        public CarDriver()
            : base(Vehicle.Types.Car)
        {

        }

        override public void Drive(Vehicle vehicle)
        {
            if(vehicle.type == this.canDrive)
            {
                Console.WriteLine($"Driving a {vehicle.Name}");
            }
            else
            {
                if(nextInChain == null)
                {
                    // Throw error or, do anything
                    Console.WriteLine($"Sorry, no one here is able to drive a {vehicle.Name}");
                }
                else
                {
                    nextInChain.Drive(vehicle);
                }
            }
        }

        override public void SetNextChainCouple(IChain chain)
        {
            nextInChain = chain;
        }
    }

    class TruckDriver : Driver
    {
        public TruckDriver()
            : base(Vehicle.Types.Truck)
        {

        }

        override public void Drive(Vehicle vehicle)
        {
            if (vehicle.type == this.canDrive)
            {
                Console.WriteLine($"Driving a {vehicle.Name}");
            }
            else
            {
                if (nextInChain == null)
                {
                    // Throw error or, do anything
                    Console.WriteLine($"Sorry, no one here is able to drive a {vehicle.Name}");
                }
                else
                {
                    nextInChain.Drive(vehicle);
                }
            }
        }

        override public void SetNextChainCouple(IChain chain)
        {
            nextInChain = chain;
        }
    }


}
