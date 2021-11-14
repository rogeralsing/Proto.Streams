using System;

namespace Actor.Streams.Shims
{
    public interface INoSerializationVerificationNeeded
    {
        
    }

    public interface IDeadLetterSuppression
    {
        
    }

    public interface IActorRefFactory
    {
        
    }

    public interface ILoggingAdapter
    {
        bool IsErrorEnabled { get; set; }
        void Error(string exceptionMessage);
        void Warning(Exception exception, string restartingGraphDueToFailure);
        void Debug(string lastRestartAttemptWasMoreThanAgoResettingRestartCount, TimeSpan settingsMaxRestartsWithin);
        void Debug(string lastRestartAttemptWasMoreThanAgoResettingRestartCount);
    }
}