using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob.Services
{
    public sealed class FakeLocalService : ILocalService
    {
        Dictionary<String, Stream> dict;

        public FakeLocalService()
        {
            dict = new Dictionary<string, Stream>();
        }

        // - Note
        //      원래라면 실제 파일을 생성해야 한다.
        //      `MemoryStream`으로 대체
        Stream ILocalService.Create(string _fname)
        {
            // Result
            Stream res = null;
            // Find in dictionary
            if(dict.TryGetValue(_fname, out res) == false){
                // 없을 경우 생성한다
                dict.Add(_fname, new MemoryStream());
            }
            return dict[_fname];
        }

        // - Note
        //      원래라면 실제 파일을 제거해야 한다.
        //      목록에서만 지운다.
        void ILocalService.Delete(string _fname)
        {
            dict.Remove(_fname);
        }

        // - Note
        //      원래라면 실제 파일을 제거해야 한다.
        //      목록에서만 지운다.
        void ILocalService.Close(Stream _stream)
        {
            if(_stream != null){
                _stream.Dispose();
            }
        }

    }

}// namespace ManaBob.Services

