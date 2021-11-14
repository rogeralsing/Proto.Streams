﻿//-----------------------------------------------------------------------
// <copyright file="IMaterializerLoggingProvider.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2021 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2021 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using Actor.Streams.Shims;

namespace Proto.Streams
{
    /// <summary>
    /// SPI intended only to be extended by custom <see cref="IMaterializer"/> implementations,
    /// that also want to provide stages they materialize with specialized <see cref="ILoggingAdapter"/> instances.
    /// </summary>
    public interface IMaterializerLoggingProvider
    {
        /// <summary>
        /// Creates a new logging adapter.
        /// </summary>
        /// <param name="logSource">The source that produces the log events.</param>
        /// <returns>The newly created logging adapter.</returns>
        ILoggingAdapter MakeLogger(object logSource);
    }
}
