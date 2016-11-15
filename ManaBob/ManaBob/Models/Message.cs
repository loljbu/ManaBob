using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    // - Note
    //      Serialization/Deserialization이 가능한 메세지
    // - Extension
    //      - Text      : text
    //      - Binary    : image
    //      - Blob      : zip
    public class Message
    {
        // - Note
        //      메세지 종류. 일부 확장자를 지원하는 것을 고려
        // - To Do
        //      우선 구현 : Text
        public enum Category
        {
            Binary,
            Text,
            //Blob,
            //JPEG,
            //PDF,
            //Zip,
        }


        public Int64    ID;
        public Category Type { get; set; }

        public Message()
        {
            this.ID = 0;
            this.Type = Category.Binary;
        }

        public Message(Int64 _id, Category _type)
        {
            this.ID = _id;
            this.Type = _type;
        }

    }

}// namespace ManaBob

