using System;
using Observer.Event;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckEvent();
        }

        static void CheckEvent()
        {
            var personFirst= new Person();
            var personSecond = new Person();
            var doctor = new Doctor();

            personFirst.FallsIll+=doctor.CallDoctor;
            personSecond.FallsIll+=doctor.CallDoctor;

            personFirst.CatchACold("Simonova St.");
            personSecond.CatchACold("Lenina St.");
        }
    }
}
