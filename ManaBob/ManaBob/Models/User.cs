using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{
    // - Note
    //      '사용자'의 기본 클래스
    //      - ID        : 사용자들의 고유 식별자
    // - To Do
    //      ID의 충돌 방지 방안?
    public class User
    {
        public UInt32 ID    { get; set; }
        public String Name  { get; set; }
    }

}// namespace ManaBob

