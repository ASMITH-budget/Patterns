using System;

namespace Observer.Event
{
    public class Person
    {
        public event EventHandler<FallsIllEventArgs> FallsIll;

        public void CatchACold(string address)
        {
            FallsIll?.Invoke(this,new FallsIllEventArgs {Address=address});
        }

    }
}