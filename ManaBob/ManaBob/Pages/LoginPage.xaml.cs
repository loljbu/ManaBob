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
        AppCore core;
        public LoginPage(AppCore _core)
        {
            core = _core;
            InitializeComponent();

            EntryID.Placeholder = "ID";
            EntryID.IsVisible = true;
            EntryPWD.Placeholder = "Password";
            EntryPWD.IsVisible = true;

        }


        public async void GoToListPage(object sender, EventArgs e)
        {
            var repo = core.Repo;
            var next = repo.Resolve<RoomListPage>();
            if (next == null) { return; }

            core.NavigateTo(next);
            await Navigation.PushAsync(new RoomListPage(core));
        }

        public async void GoToWebPage(object sender, EventArgs e)
        {
            var repo = core.Repo;
            var next = repo.Resolve<RoomListPage>();
            if (next == null) { return; }

            core.NavigateTo(next);
            await Navigation.PushAsync(new RoomListPage(core));
        }

        public void GoToBack(object sender, EventArgs e)
        {
            core.Pop();
        }

    }

}
