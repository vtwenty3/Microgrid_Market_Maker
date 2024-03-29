﻿using SocketServerLib.Server;

namespace AsyncClientServerLib.Server
{
    /// <summary>
    /// Basic Socket Server. Implements the AbstractSocketServer class. The socket client handler class is BasicSocketClientHandler.
    /// </summary>
    internal class BasicSocketServer : AbstractSocketServer
    {
        /// <summary>
        /// Return a BasicSocketClientHandler instance.
        /// </summary>
        /// <param name="handler">The socket client handler</param>
        /// <param name="sslStream">The ssl stream</param>
        /// <param name="sendHandleTimeout">The send timeout</param>
        /// <param name="socketSendTimeout">The socket timeout</param>
        /// <returns>The socket client handler</returns>
        protected override SocketServerLib.SocketHandler.AbstractTcpSocketClientHandler GetHandler(System.Net.Sockets.Socket handler, System.Net.Security.SslStream sslStream)
        {
            return new AsyncClientServerLib.SocketHandler.AsyncSocketClientHandler(handler, sslStream);
        }
    }
}
