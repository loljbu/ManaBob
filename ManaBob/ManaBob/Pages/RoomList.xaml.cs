using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ManaBob;

namespace ManaBob.Pages
{

    public static class RoomListTest
    {
        public static List<Room> GetRoomList()
        {
            return new List<Room>
            {
                new Room {
                    Title = "Room !1",
                    ID = 1,
                    Menu = Menu.Unknown,
                    Budget = 6000,
                    Size = 2,
                    Capacity = 2
                },
                new Room {
                    Title = "Room @2",
                    ID = 2, Menu = Menu.Kor, Budget = 4000, Size = 1, Capacity = 4
                },
                new Room {
                    Title = "Room #3",
                    ID = 3,
                    Menu = Menu.Unknown,
                    Budget = 8200,
                    Size = 2,
                    Capacity = 3
                },
                new Room {
                    Title = "Room $4",
                    ID = 4,
                    Menu = Menu.Unknown,
                    Budget = 5000,
                    Size = 4,
                    Capacity = 4
                },
                new Room {
                    Title = "Room %5",
                    ID = 5,
                    Menu = Menu.Unknown,
                    Budget = 5500,
                    Size = 3,
                    Capacity = 4
                }
            };
        }
    }


    public class RoomDataTemplate
    {
        TextCell cell;
    }


	public partial class RoomList : ContentPage
	{
        Navigator navi;
        Repository pages;

        public RoomList (Navigator _navi, Repository _pages)
		{
            navi = _navi;
            pages = _pages;
			InitializeComponent ();

            //List<Room> rooms = RoomListTest.GetRoomList();
            roomListView.ItemTapped += (sender, args)=>
            {
                var item = args.Item as Room;
                if(item == null)
                {
                    return;
                }
                this.appName.Text = item.Title;
                roomListView.SelectedItem = null;
            };

            roomListView.ItemTemplate = new DataTemplate(typeof(TextCell));
            roomListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            roomListView.ItemsSource = RoomListTest.GetRoomList();
        }

	}
}
