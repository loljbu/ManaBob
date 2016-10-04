using System;
using System.Collections.Generic;
using System.Text;

namespace ManaBob.ViewModel
{
    class RoomListViewModel
    {
        // - Note
        //      현재 보유한 Room 들을 특정 기준으로 필터링
        // - To Do
        //      전체 목록은 어디에 보관??
        //      필터를 변경할 경우 오버헤드?
        //      필터링 하면서 동기화하는 방법?
        public static List<Model.Room> Filter()
        {
            throw new NotImplementedException();
        }

        // - Note
        //      주어진 Room 들을 특정 기준으로 재정렬
        public static List<Model.Room> Sort(List<Model.Room> _list)
        {
            throw new NotImplementedException();
        }

        // - Note
        //      사용자가 지정한 방에 입장
        public void Enter(Model.Room _room)
        {
            throw new NotImplementedException();
        }

    }
}
