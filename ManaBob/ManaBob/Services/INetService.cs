using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ManaBob.Services
{

    // - Note
    //      Network service에 대한 Dependency를 최소화 하기 위한 
    //       Wrapper 인터페이스.
    //      가장 기본적인 수준의 동기/비동기 송수신 기능을 사용
    // - Exception
    //      심각한 경우에만 예외를 사용하며, 
    //      기본적으로는 반환값을 사용에 Error Code를 전파
    interface INetService
    {
        // - Note
        //      Server's endpoint. Possibly read-only
        // - Return
        //      TcpClient??
        int Remote { get; }

        // - Note
        //      서버와의 연결이 끊긴 경우 복원한다.
        //      예외를 던지지 않는다.
        // - Return
        //      연결 회복의 성공여부
        bool Recover();

        // - Note
        //      Send 'all' bytes asynchronously
        Task<bool> SendAsync(Byte[] _buffer);

        // - Note
        //      Receive 'some' bytes asynchronously
        Task<bool> RecvAsync(out Byte[] _buffer);

        // - Note
        //      Gracefully close connection with server
        void Close();

        // - Note
        //      Check the network service status
        bool IsConnected { get; }

    }

}// namespace ManaBob.Services
