using System;
using Observer.Event;

namespace Observer.Event
{
    public delegate void DoctorEventHandler<T>(object sender, FallsIllEventArgs eventArgs);

    public class Person
    {
        public event DoctorEventHandler<FallsIllEventArgs> FallsIllEvent;

        public void CatchACold(string address, int house)
        {
            FallsIllEvent?.Invoke(this, new FallsIllEventArgs { Address = address, House=house });
        }

    }
}