﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ManaBob.Services
{

    public interface INetService : IDisposable
    {
        /// <summary>
        ///     Send a message to Server. No response
        /// </summary>
        Task            Send(Message _message);

        /// <summary>
        ///     Send a request to Server. Receive a response about it.
        /// </summary>
        Task<Response>  Request(Request _req);

        /// <summary>
        ///     연결 상태를 확인
        /// </summary>
        bool IsConnected { get; }

    }





}// namespace ManaBob.Services
