using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManaBob.Services
{
    // - Note
    //      Local System API에 대한 Wrapper 인터페이스.
    //      Service는 자원에 대한 관리만을 담당하며,
    //      CRUD를 동작을 위해 필요한 Stream들의 소유권을 가진다.
    //       - Create : 특정 file에 대한 Stream을 획득한다.
    //       - Read   : Read는 Stream Reader에게 위임
    //       - Update : Write는 Stream Writer에게 위임
    //       - Delete : 특정 file을 지운다.
    // - Exception
    //      문제가 발생할 수 있는 경우 예외를 사용한다.
    //      즉, 반환 Value/Object를 획득할 수 없으면 예외를 던진다
    // - Caution
    //      소멸 시점에 소유한 모든 File들을 해제해야 한다.
    public interface ILocalService
    {
        // - Note
        //      `StreamWriter`, `StreamReader`에서 사용할 수 있는 
        //      `Stream`을 반환한다.
        Stream  Create(String _fname);

        // - Note
        //      시스템에서 더이상 해당 `Stream`을 사용하지 않는다.
        //      적절한 시기에 관련된 System resource의 clean up을 수행한다.
        void    Close(System.IO.Stream _stream);

        // - Note
        //      지정 폴더(Directory)에 있는 해당 파일을 지운다.
        void    Delete(String _fname);
    }

}// namespace ManaBob.Services

