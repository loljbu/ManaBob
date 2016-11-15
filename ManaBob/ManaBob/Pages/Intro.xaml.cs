using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class Intro : ContentPage
    {
        Navigator navi;
        Repository pages;

        public Intro(Navigator _navi, Repository _pages)
        {
            navi = _navi;
            pages = _pages;
            InitializeComponent();
        }
        protected void GoToLoginPage(object sender, EventArgs e)
        {
            //var next = pages.Resolve<LoginPage>();
            //if(next == null) { return; }

            //navi.GoAsyncTo(new NavigationPage(next));
        }
    }

}
