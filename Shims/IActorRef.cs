using Proto.Streams.Implementation;

namespace Proto
{
    public interface IActorRef 
    {
        void Tell(object message);
        void Tell(object message, IActorRef self);
    }
}