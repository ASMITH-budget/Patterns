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
            var personFirst = new Person();
            var personSecond = new Person();
            var doctor = new Doctor();

            personFirst.FallsIllEvent += doctor.OnCallDoctor;
            personSecond.FallsIllEvent += doctor.OnCallDoctor;

            personFirst.CatchACold("Simonova St.",27);
            personSecond.CatchACold("Lenina St.",111);
        }
    }
}