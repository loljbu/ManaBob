using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    // - Note
    //      외부 Map API 사용시 필요한 값들을 구조화
    // - Caution
    //      값 문맥(Value Semantic)
    public struct Location
    {
        public Double Longitude;
        public Double Latitude;

        // - Note
        //      명시적으로 생성하여야 함
        public Location(Double _long, Double _lat)
        {
            this.Longitude = _long;
            this.Latitude = _lat;
        }

    }

    // - Note
    //      특정한 장소. 이름과 위치를 기본으로 사용
    // - To Do
    //      추가적으로 필요한 정보?
    public class Spot
    {
        public String Name;
        public String Description;
        //public Location Location;
    }

}// namespace ManaBob
