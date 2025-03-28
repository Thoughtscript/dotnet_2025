using System;

namespace Language.Events
{
    class CustomEventSubscriber
    {
        private CustomEventPublisher _customEventPublisher;

        public CustomEventSubscriber(CustomEventPublisher customEventPublisher) {
            this._customEventPublisher = customEventPublisher;
        }

        private void Subscribed() {
            Console.WriteLine("Subscribed to CustomEvent!");
        }

        public void SubscribeToPublisher() {
            if (_customEventPublisher is not null)
            {
                _customEventPublisher.CustomEvent += Subscribed;
            }
        }
    }
}