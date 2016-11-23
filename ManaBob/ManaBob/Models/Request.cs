using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{
    public class Request
    {
        public enum Category
        {
            CreateRoom,
            ChangeRoom,
            CloseRoom,

            EnterRoom,
            LeaveRoom,

            Login,
            Logout,
        }

        public User         Sender      { get; set; }
        public Category     Type        { get; private set; }
        public DateTime     TimeStamp   { get; private set; }
        public String       Content     { get; set; }


        public Request(){}

        public Request(User _sender, Category _type, String _content)
        {
            Sender      = _sender;
            Type        = _type;
            TimeStamp   = DateTime.Now;
            Content     = _content;
        }

    }

}
