using System;
using Reactive.Streams;

namespace Proto.Streams.Actors
{
    /// <summary>
    /// TBD
    /// </summary>
    /// <typeparam name="T">TBD</typeparam>
    public sealed class ActorSubscriberImpl<T> : ISubscriber<T>
    {
        private readonly IActorRef _impl;

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="impl">TBD</param>
        /// <exception cref="ArgumentNullException">
        /// This exception is thrown when the specified <paramref name="impl"/> is undefined.
        /// </exception>
        public ActorSubscriberImpl(IActorRef impl)
        {
            if (impl == null) throw new ArgumentNullException(nameof(impl), "ActorSubscriberImpl requires actor impl to be defined");
            _impl = impl;
        }

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="subscription">TBD</param>
        /// <exception cref="ArgumentNullException">
        /// This exception is thrown when the specified <paramref name="subscription"/> is undefined.
        /// </exception>
        public void OnSubscribe(ISubscription subscription)
        {
            if (subscription == null) throw new ArgumentNullException(nameof(subscription), "OnSubscribe requires subscription to be defined");
            _impl.Tell(new OnSubscribe(subscription));
        }

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="element">TBD</param>
        public void OnNext(T element) => OnNext((object)element);

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="element">TBD</param>
        /// <exception cref="ArgumentNullException">
        /// This exception is thrown when the specified <paramref name="element"/> is undefined.
        /// </exception>
        public void OnNext(object element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element), "OnNext requires provided element not to be null");
            _impl.Tell(new OnNext(element));
        }

        /// <summary>
        /// TBD
        /// </summary>
        /// <param name="cause">TBD</param>
        /// <exception cref="ArgumentNullException">
        /// This exception is thrown when the specified <paramref name="cause"/> is undefined.
        /// </exception>
        public void OnError(Exception cause)
        {
            if (cause == null) throw new ArgumentNullException(nameof(cause), "OnError has no cause defined");
            _impl.Tell(new OnError(cause));
        }

        /// <summary>
        /// TBD
        /// </summary>
        public void OnComplete() => _impl.Tell(Actors.OnComplete.Instance);
    }
}