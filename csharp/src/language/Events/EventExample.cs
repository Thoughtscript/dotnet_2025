using System;
using Language.Interfaces;

// Really helpful and clean Pub Sub example: 
// https://github.com/ggagnaux/CSharp-Publisher-Subscriber-Demo/tree/master/PublisherSubscriberDemo
namespace Language.Events
{
    class EventExample : IExample
    {
        public static void Run()
        {
            CustomEventPublisher customEventPublisher = new CustomEventPublisher();
            CustomEventSubscriber customEventSubscriber = new CustomEventSubscriber(customEventPublisher);
            customEventSubscriber.SubscribeToPublisher();
            customEventPublisher.Send();
        }
    }
}