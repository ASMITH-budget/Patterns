using System;

namespace Observer.Event
{
    public class Doctor
    {
        public void OnCallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            System.Console.WriteLine($"I'm going to {eventArgs.Address.ToString()} , {eventArgs.House.ToString()} !!!");
        }
    }
}