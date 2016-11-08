using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    /// <summary>
    ///     외부 Map API 사용시 필요한 값들을 구조화
    /// </summary>
    public class Location
    {
        public Double Long { get; set; }
        public Double Lat { get; set; }

        public Location(Double _long, Double _lat)
        {
            Long = _long;
            Lat = _lat;
        }

    }

    /// <summary>
    ///     특정한 장소. 이름과 설명, 위치를 기본으로 사용
    /// </summary>
    public class Spot
    {
        public String   Name { get; set; }
        public String   Note { get; set; }
        public Location Place { get; set; }
    }

}// namespace ManaBob
