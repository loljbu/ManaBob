using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    /// <summary>
    ///      '채팅방'의 기본 클래스
    ///      - Title     : 방 이름
    ///      - ID        : 방들의 고유 식별자
    ///      - Menu      : 먹을거리
    ///      - Budget    : 1인당 식비 예산
    ///      - Capacity  : 최대 인원수
    ///      - Size      : 현재 인원수
    /// </summary>
    /// <remarks>
    ///      ID의 충돌 방지 방안?
    ///      최대 인원수는 필수적인가?
    /// </remarks>
    public class Room
    {
        public String   Title     { get; set; }
        public UInt32   ID        { get; set; }
        public Menu     Menu      { get; set; }
        public Decimal  Budget    { get; set; }
        public UInt16   Capacity  { get; set; }
        public UInt16   Size      { get; set; }
    }

}// namespace ManaBob

