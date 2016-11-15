using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class IntroPage : ContentPage
    {
        AppCore core;

        public IntroPage(AppCore _core)
        {
            core = _core;
            InitializeComponent();
        }

        protected void GoToLoginPage(object sender, EventArgs e)
        {
            var next = core.Repo.Resolve<LoginPage>();
            if(next == null) { return; }

            core.NavigateTo(next);
        }

    }
}
