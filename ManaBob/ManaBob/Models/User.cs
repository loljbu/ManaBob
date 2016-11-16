using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{
    /// <summary>
    ///      '사용자'의 기본 클래스
    ///      - ID    : 사용자들의 고유 식별자. 유효하지 않은 경우 음수를 사용
    /// </summary>
    public class User
    {
        public Int64  ID    { get; set; }
        public String Name  { get; set; }
    }

}// namespace ManaBob

