using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    /// <summary>
    ///      '채팅방'의 기본 클래스
    ///      - ID        : 방들의 고유 식별자
    ///      - Menu      : 먹을거리
    ///      - Budget    : 1인당 식비 예산
    ///      - Capacity  : 최대 인원수
    ///      - Count     : 현재 인원수
    /// </summary>
    /// <remarks>
    ///      ID의 충돌 방지 방안?
    ///      최대 인원수는 필수적인가?
    /// </remarks>
    public class Room
    {
        public UInt32   ID        { get; set; }
        public Menu     Menu      { get; set; }
        public Decimal  Budget    { get; set; }
        public UInt16   Capacity  { get; set; }
        public UInt16   Count     { get; set; }
    }

}// namespace ManaBob

