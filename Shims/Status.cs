using System;

namespace Actor.Streams.Shims
{
    public class Status
    {
        public record Success();

        public record Failure(Exception x);
    }
}