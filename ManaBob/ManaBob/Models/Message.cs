using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    /// <summary>
    ///     Serialization/Deserialization이 가능한 메세지
    /// </summary>
    public class Message
    {
        // - Note
        //      메세지 종류. 일부 확장자를 지원하는 것을 고려
        // - To Do
        //      우선 구현 : Text
        public enum Tag
        {
            Binary,
            Text
        }

        public String   Sender { get; set; }
        public Int64    SenderID { get; set; }
        public Tag      Type { get; set; }
        /// <summary>
        /// Serialized Bytes
        /// </summary>
        public Byte[]   Bytes { get; set; }


        public Message(String _sender, String _text)
        {
            Sender = _sender;
            SenderID = _sender.GetHashCode();
            Type = Tag.Text;
            Bytes = Encoding.UTF8.GetBytes(_text);
        }

        public Message(String _sender, Byte[] _bytes)
        {
            Sender = _sender;
            SenderID = _sender.GetHashCode();
            Type = Tag.Binary;
            Bytes = _bytes;
        }

    }

}// namespace ManaBob

