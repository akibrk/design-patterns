using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Principles
{
    class OpenClosed
    {
        OpenClosed()
        {
            OCSender sender = new OCSender("Akib", "Hi there");
            OCNotificationService senderNotification = new OCNotificationService(sender);
            senderNotification.Alert();
        }

    }

    class OCBadEntity
    {
        public string Name { get; set; }
        public string Bio {get; set;}

    }

    class Sender : OCBadEntity
    {
        public Sender(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }
    }
    class Receiver : OCBadEntity
    {
        public Receiver(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }
    }

    class NotificationService
    {
        private readonly OCBadEntity _user;
        public NotificationService(OCBadEntity user)
        {
            _user = user;
        }
        public void Alert()
        {
            if(_user is Sender)
            {
                Console.WriteLine($"Your message has been sent!");
            }else if (_user is Receiver)
            {
                Console.WriteLine($"One new message");
            }
        }
    }

    // Better

    class OCEntity 
    { 
        public string Name { get; set; }
        public string Bio { get; set; }

        public void Alert()
        {
            Console.WriteLine("Alert from entity");
        }
    }

    class OCSender : OCEntity
    {
        public OCSender(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }

        new public void Alert()
        {
            Console.WriteLine("Your message has been sent");
        }
    }

    class OCPlayer : OCEntity
    {
        public OCPlayer(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }

        new public void Alert()
        {
            Console.WriteLine("Player message has been sent");
        }
    }

    class OCReceiver:OCEntity
    {
        public OCReceiver(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }

        new public void Alert()
        {
            Console.WriteLine("A new message");
        }

    }

    class OCNotificationService
    {
        private readonly OCEntity _entity;
        public OCNotificationService(OCEntity entity)
        {
            _entity = entity;
        }
        public void Alert()
        {
            // We can send the notification to db / local
            // We don't need any conditional
            // We can create any sub class of OCEntity and pass it in for notification
            _entity.Alert();
        }
    }

}
