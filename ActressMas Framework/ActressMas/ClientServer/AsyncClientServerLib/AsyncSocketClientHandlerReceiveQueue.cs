﻿using AsyncClientServerLib.Message;
using SocketServerLib.Message;
using SocketServerLib.SocketHandler;
using System.Net.Security;
using System.Net.Sockets;

namespace AsyncClientServerLib.SocketHandler
{
    /// <summary>
    /// Basic Socket Client Handler. Implements the AbstractAsyncTcpSocketClientHandler class. The message class is BasicMessage.
    /// </summary>
    internal class AsyncSocketClientHandlerReceiveQueue : AbstractAsyncTcpSocketClientHandler
    {
        /// <summary>
        /// The constructor for SSL connection.
        /// </summary>
        /// <param name="handler">The socket cient handler</param>
        /// <param name="stream">The ssl stream</param>
        public AsyncSocketClientHandlerReceiveQueue(Socket handler, SslStream stream)
            : base(handler, stream, true)
        {
        }

        /// <summary>
        /// The constructor for not SSL connection.
        /// </summary>
        /// <param name="handler">The socket cient handler</param>
        public AsyncSocketClientHandlerReceiveQueue(Socket handler)
            : base(handler, null, true)
        {
        }

        /// <summary>
        /// Return a BasicMessage empty instance.
        /// </summary>
        /// <returns>The BasicMessage instance</returns>
        protected override AbstractMessage GetMessageInstance()
        {
            return new BasicMessage();
        }
    }
}
