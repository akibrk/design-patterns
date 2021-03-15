
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.Mediator
{
    public class MediatorPatternApp
    {
        public MediatorPatternApp()
        {
            var chat = new Chatroom();

            var user1 = new Home("Akib");
            var user2 = new Home("Zark");
            var work1 = new Work("John");
            
            chat.Register(user1);
            chat.Register(user2);
            chat.Register(work1);

            user1.Send("Hey Zark", "Zark");
            work1.Send("Are you available?", "Akib");

        }
    }


    /// <summary>
    /// Mediator
    /// </summary>
    interface IChatroom
    {
        public void Register(Participant participant);
        public void Send(string message, string to, string from);
    }

    /// <summary>
    /// Concrete Mediator
    /// </summary>
    class Chatroom : IChatroom
    {
        private readonly Dictionary<string, Participant> participants;

        public Chatroom()
        {
            participants = new Dictionary<string, Participant>();
        }

        public void Register(Participant participant)
        {
            participants.Add(participant.Name, participant);
            participant.Chatroom = this;
        }

        public void Send(string message, string to, string from)
        {
            Participant toWhom = participants.GetValueOrDefault(to);
            toWhom.Receive(message, from);
        }
    }

    /// <summary>
    /// Abstract Collegue
    /// </summary>
    abstract class Participant
    {
        private string _name;
        private IChatroom _chatroom;

        public Participant(string name)
        {
            _name = name;
        }


        public string Name { get {
                return _name;
            } }
        public IChatroom Chatroom 
        { 
            get
            {
                return _chatroom;
            }

            set
            {
                _chatroom = value;
            }
        }

        virtual public void Send(string message, string to)
        {
            _chatroom.Send(message, to, this._name);
        }

        virtual public void Receive(string message, string from)
        {
            Console.WriteLine($"From {from} to {Name}: {message}");
        }

    }

    class Home : Participant
    {
        public Home(string name)
            : base(name)
        {

        }

        public override void Send(string message, string to)
        {
            Console.WriteLine("Sending to home member..");
            base.Send(message, to);
        }

        public override void Receive(string message, string from)
        {
            base.Receive(message, from);
        }
    }

    class Work : Participant
    {
        public Work(string name)
            : base(name)
        {

        }

        public override void Send(string message, string to)
        {
            Console.WriteLine("Sending to work collegue..");
            base.Send(message, to);
        }
        public override void Receive(string message, string from)
        {
            base.Receive(message, from);
        }
    }




}
