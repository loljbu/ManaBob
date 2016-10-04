using System;
using System.Collections.Generic;
using System.Text;

namespace ManaBob.Model
{
    // - Note
    //      식사 메뉴. 필터링에 사용 가능
    // - To Do
    //      확장, 추가
    enum Menu
    {
        Unknown,    // Default value
        Korean,
    }

    // - Note
    //      외부 Map API 사용시 필요한 값들을 구조화
    // - Caution
    //      값 문맥(Value Semantic)
    struct Location
    {
        public int Longitude, Latitude;

        public Location(int _long, int _lat)
        {
            this.Longitude = _long;
            this.Latitude  = _lat;
        }
    }

    // - Note
    //      특정한 장소. 이름과 위치를 기본으로 사용
    // - To Do
    //      추가적으로 필요한 정보?
    class Spot
    {
        public String   Name;
        //public String   Description;
        public Location Location;
    }

    // - Note
    //      '사용자'의 기본 클래스
    //      - ID        : 사용자들의 고유 식별자
    // - To Do
    //      ID의 충돌 방지 방안?
    class Human
    {
        public UInt32 ID { get; set; }
    }

    // - Note
    //      '채팅방'의 기본 클래스
    //      - ID        : 방들의 고유 식별자
    //      - Menu      : 먹을거리
    //      - Budget    : 1인당 식비 예산
    //      - Capacity  : 최대 인원수
    //      - Count     : 현재 인원수
    // - To Do
    //      ID의 충돌 방지 방안?
    //      최대 인원수는 필수적인가?
    class Room
    {
        public UInt32  ID       { get; set; }
        public Menu    Menu;
        public Decimal Budget   { get; set; }
        public UInt16  Capacity { get; set; }
        public UInt16  Count    { get; set; }
    }


    // - Note
    //      메세지 종류. 일부 확장자를 지원하는 것을 고려
    // - To Do
    //      우선 구현 : Text
    enum MCategory
    {
        //Binary,
        Text,
        //Blob,
        //JPEG,
        //PDF,
        //Zip,
    }

    // - Note
    //      Serialization/Deserialization이 가능한 메세지
    // - Extension
    //      - Text      : text
    //      - Binary    : image
    //      - Blob      : zip
    class Message
    {
        public MCategory Category { get; set; }
    }


}// namespace ManaBob.Model

