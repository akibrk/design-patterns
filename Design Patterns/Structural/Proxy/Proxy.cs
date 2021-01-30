using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Proxy
{
    public class Proxy
    {
        // Driver code goes here
        public Proxy()
        {
            _ = new Client();
        }
    }


    // Gets a Proxy does the same thing as the Subject
    // Client Sends a request to a Subject to do something
    public class Client
    {
        // I need money!
        // Let's call the office
        private Phone phone;

        public Client()
        {
            phone = new Phone();
            phone.CallOffice();
        }
    }

    // Just a medium
    // Instead of using the real subject uses the proxy
    public class Phone
    {
        public ISubject _subject;
        public Phone()
        {
            _subject = new OfficeProxy();
        }

        public void CallOffice()
        {
            Console.WriteLine("Calling office for money!");
            _subject.PayMoney();
        }
    }


    public interface ISubject
    {
        public void PayMoney();
    }

    // Fake Subject
    public class OfficeProxy: ISubject
    {
        private ISubject _subject;
        public OfficeProxy()
        {
            // Do something else
        }

        // Do something else

        // Lazy construction
        public void PayMoney()
        {
            if(_subject == null)
            {
                _subject = new Office();
            }

            _subject.PayMoney();
        }

    }


    // Real Subject
    public class Office: ISubject
    {
        public void PayMoney()
        {
            Console.WriteLine("Paying money");
        }
    }
}
