using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManaBob
{
    public interface ILocalService
    {
        // - Note
        //      `StreamWriter`, `StreamReader`에서 사용할 수 있는 
        //      `Stream`을 반환한다.
        Stream Create(String _fname);

        // - Note
        //      시스템에서 더이상 해당 `Stream`을 사용하지 않는다.
        //      적절한 시기에 관련된 System resource의 clean up을 수행한다.
        void Close(System.IO.Stream _stream);

        // - Note
        //      지정 폴더(Directory)에 있는 해당 파일을 지운다.
        void Delete(String _fname);
    }
}
