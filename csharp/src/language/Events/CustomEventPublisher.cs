using System;

namespace Language.Events
{
    class CustomEventPublisher
    {
        // Declare delegate - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
        public delegate void CustomEventHandler();

        // Declare the event - EventHandler delegate and Event
        public event CustomEventHandler CustomEvent;

        public virtual void Send()
        {
            Console.WriteLine("CustomEvent Sent!");
            CustomEvent?.Invoke();
        }
    }
}