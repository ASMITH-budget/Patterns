using System;

namespace Observer.Event
{
    public class Doctor
    {
        public void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            System.Console.WriteLine($"I'm going to {eventArgs.Address.ToString()}!!!");
        }
    }
}