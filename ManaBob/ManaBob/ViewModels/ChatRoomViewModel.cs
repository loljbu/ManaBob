using System;
using System.Collections.Generic;
using System.Text;

namespace ManaBob.ViewModel
{
    public class ChatRoomViewModel
    {
        // - Note
        //      메세지 전송
        public void Send(Message _msg)
        {
            throw new NotImplementedException();
        }

        // - Note
        //      방의 내용을 갱신. 필요시 서버에게 Sync 요청 가능
        public void Update()
        {
            throw new NotImplementedException();
        }

        // - Note
        //      방을 떠남
        public void Leave()
        {
            throw new NotImplementedException();
        }

    }

}// namespace ManaBob.ViewModel
