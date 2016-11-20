using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    public class Response
    {
        public User                 Sender      { get; set; }
        public Request.Category     Type        { get; set; }
        public DateTime             TimeStamp   { get; set; }
        public Boolean              Success     { get; set; }
        public String               Reason      { get; set; }
    }

}
