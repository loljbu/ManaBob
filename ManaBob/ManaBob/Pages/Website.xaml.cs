using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class Website : ContentPage
    {
        Navigator navi;
        Repository pages;

        public Website(Navigator _navi, Repository _pages)
        {
            navi = _navi;
            pages = _pages;
            InitializeComponent();
        }

        public void Display(UrlWebViewSource _source)
        {
            //this.webView.Source = _source;
        }
    }
}
