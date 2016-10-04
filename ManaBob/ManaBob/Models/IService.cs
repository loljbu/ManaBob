using System;
using System.Collections.Generic;
using System.Text;

namespace ManaBob.Model
{

    // - Note
    //      Local System API에 대한 Wrapper 인터페이스.
    //      Platform에 따라서 세부 구현은 달라질 수 있도록 지원
    // - Exception
    //      심각한 경우에만 예외를 사용하며, 
    //      기본적으로는 반환값을 사용에 Error Code를 전파
    interface ILocalService
    {
    }

    // - Note
    //      Network service에 대한 Dependency를 최소화 하기 위한 
    //       Wrapper 인터페이스.
    //      가장 기본적인 수준의 동기/비동기 송수신 기능을 사용
    // - Exception
    //      심각한 경우에만 예외를 사용하며, 
    //      기본적으로는 반환값을 사용에 Error Code를 전파
    interface INetService
    {
    }

    // - Note
    //      Application에서 사용하는 System/Network 접점을
    //       제공하는 Wrapper Interface
    interface IService
    {
        ILocalService Local { get; }
        INetService   Net   { get; }
    }
}
