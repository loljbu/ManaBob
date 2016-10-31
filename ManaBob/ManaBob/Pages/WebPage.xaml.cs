using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class WebPage : ContentPage
    {
        AppCore core;
        public WebPage(AppCore _core)
        {
            core = _core;
            InitializeComponent();
        }

        public void Display(UrlWebViewSource _source)
        {
            this.webView.Source = _source;
        }
    }
}
