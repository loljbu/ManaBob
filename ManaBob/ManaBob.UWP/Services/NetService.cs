using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using ManaBob.Services;


namespace ManaBob.UWP.Services
{

    public class UWPNetService : INetService
    {
        //static IPAddress serviceAddr = IPAddress.IPv6Loopback;
        //static int servicePort = 31357;

        Socket sock = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);

        /// <summary>
        ///     Implicitly connect to remote server.
        /// </summary>
        public UWPNetService(IPEndPoint serverEp)
        {
            sock.Connect(serverEp);
        }

        /// <summary>
        ///     Send some bytes to server.
        /// </summary>
        private Task SendBytes(Byte[] _buffer)
        {
            return Task.Factory.StartNew(() =>
            {
                int len = sock.Send(_buffer);
            });
        }

        /// <summary>
        ///     Send Message to Server
        /// </summary>
        /// <seealso cref="Message"/>
        public Task Send(Message _message)
        {
            var msg_json = Format.ToJson(_message);
            Byte[] buffer = Encoding.UTF8.GetBytes(msg_json);

            return this.SendBytes(buffer);
        }

        /// <summary>
        ///     Send Request to Server. Then wait for the response...
        /// </summary>
        /// <seealso cref="ManaBob.Request"/>
        /// <seealso cref="ManaBob.Response"/>
        public Task<Response> Request(Request _req)
        {
            var req_json = Format.ToJson(_req);
            Byte[] buffer = Encoding.UTF8.GetBytes(req_json);

            var task = this.SendBytes(buffer);

            return Task<Response>.Factory.StartNew(() =>
            {
                task.Wait();
                return new Response(_req, false, Format.ToJson(_req));
            });
        }


        /// <summary>
        ///     Check if the socket is connected
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return sock.Connected;
            }
        }

        /// <summary>
        ///     Dispose the inner resources
        /// </summary>
        public void Dispose()
        {
            sock.Dispose();
        }
    }

}
