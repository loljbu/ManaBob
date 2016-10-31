using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ManaBob.Services
{

    /// <summary>
    ///     기본적인 수준의 동기/비동기 송수신 기능을 사용
    /// </summary>
    public interface INetService : IDisposable
    {

        /// <summary>
        ///     서버와 연결이 끊긴 경우 복원한다.
        /// </summary>
        /// <returns>
        ///     연결 회복의 성공여부
        /// </returns>
        bool Recover();

        /// <summary>
        ///     동기적 전송
        /// </summary>
        int Send(Byte[] _buffer, int _offset, int _length);

        /// <summary>
        ///     동기적 수신
        /// </summary>
        int Receive(Byte[] _buffer, int _offset, int _length);

        /// <summary>
        ///     비동기 전송
        /// </summary>
        Task<int> SendAsync(Byte[] _buffer, int _offset, int _length);

        /// <summary>
        ///     비동기 수신
        /// </summary>
        Task<int> ReceiveAsync(Byte[] _buffer, int _offset, int _length);

        /// <summary>
        ///     명시적 Close 명령
        /// </summary>
        void Close();

        /// <summary>
        ///     연결 상태를 확인
        /// </summary>
        bool IsConnected { get; }

    }

}// namespace ManaBob.Services
