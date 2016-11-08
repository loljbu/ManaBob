using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class LoginPage : ContentPage
    {
        Navigator navi;
        Repository pages;

        public LoginPage(Navigator _navi, Repository _page)
        {
            navi = _navi;
            pages = _page;
            InitializeComponent();
            
        }

        public async Task<bool> Alert(string _title, 
                                      string _message, 
                                      string _true, string _false)
        {
            bool choice = await DisplayAlert(_title, _message, _true, _false);
            return choice;
        }

        public void GoToListPage(object sender, EventArgs e)
        {
            var page = pages.Resolve<RoomListPage>();
            if (page == null) { return; }

            var next = new NavigationPage(page);
            navi.PushAsyncTo(next);
        }

        public void GoToWebPage(object sender, EventArgs e)
        {
            var page = pages.Resolve<WebPage>();
            if (page == null) { return; }

            var next = new NavigationPage(page);
            navi.PushAsyncTo(next);
        }

        public void GoToBack(object sender, EventArgs e)
        {
            navi.PopAsync();
        }

    }

}
