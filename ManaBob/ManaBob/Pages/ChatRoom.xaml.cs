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
                new Message(1111, 8888, Format.ToJson("JSON Text1")),
                new Message(2222, 8888, Format.ToJson("JSON Text2")),
                new Message(3333, 8888, Format.ToJson("JSON Text3")),
            };
        }
    }

	public partial class ChatRoom : ContentPage
	{
        Navigator navi;
        Repo<NavigationPage> pages;


        public ChatRoom (Navigator _navi, Repo<NavigationPage> _pages)
		{
            navi = _navi;
            pages = _pages;
			InitializeComponent();
		}
	}
}
