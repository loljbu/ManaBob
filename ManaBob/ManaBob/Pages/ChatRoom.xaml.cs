using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ManaBob;
namespace ManaBob.Pages
{

    public static class ChatRoomTest
    {
        static List<Message> GetMessages()
        {
            return new List<Message>
            {
                new Message("Sender1", Format.ToJson("JSON Text1")),
                new Message("Sender2", "Text2"),
                new Message("Sender3", "Text3"),
            };
        }
    }

	public partial class ChatRoom : ContentPage
	{
        Navigator navi;
        Repository pages;

        public ChatRoom (Navigator _navi, Repository _pages)
		{
            navi = _navi;
            pages = _pages;
			InitializeComponent();
		}
	}
}
