using System;
using System.Threading.Tasks;
using Proto;

namespace Proto
{
    public class ActorBase : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            return Task.CompletedTask;
        }

        protected virtual void PostStop()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void PostRestart(Exception reason)
        {
            throw new NotImplementedException();
        }

        protected virtual bool Receive(object message)
        {
            throw new NotImplementedException();
        }
    }
}