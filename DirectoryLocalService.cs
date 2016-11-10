using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManaBob
{
    class DirectoryLocalService : ILocalService
    {
        // - Note
        //      원래라면 실제 파일을 생성해야 한다.
        //      `MemoryStream`으로 대체
        Stream ILocalService.Create(string _fname)
        {
            // _fname 경로의 파일이 있으면 열고 없으면 새로 생성한다.
            Stream Str = new FileStream(_fname, FileMode.OpenOrCreate);
            //만든 Stream을 반환.
            return Str;
        }

        // - Note
        //      원래라면 실제 파일을 제거해야 한다.
        //      목록에서만 지운다.
        void ILocalService.Delete(string _fname)
        {
            //파일의 경로를 받아 파일의 정보를 가진 변수를 만든다.
            FileInfo Fi = new FileInfo(_fname);

            // 파일을 제거한다.
            Fi.Delete();
        }

        // - Note
        //      원래라면 실제 파일을 제거해야 한다.
        //      목록에서만 지운다.
        void ILocalService.Close(Stream _stream)
        {
            _stream.Close();
        }
        public DirectoryLocalService(string directory)
        {
            //directory = "C:\\Users\\USER\\Desktop\\test";

            //filepath = "\\test.txt";
            //DirectoryInfo dir = new DirectoryInfo(directory);
            //dir.Create();
        }
    }
}
