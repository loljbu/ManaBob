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
        public LoginPage()
        {

            InitializeComponent();

            EntryID.Placeholder = "ID";
            EntryID.IsVisible = true;
            EntryPWD.Placeholder = "Password";
            EntryPWD.IsVisible = true;

        }


        public async void GoToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoomListPage());
        }

        public async void GoToWebPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebPage());
        }

        public async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }

}
