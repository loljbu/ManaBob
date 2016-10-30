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
        WebView _web = new WebView();

        public WebPage()
        {
            _web.VerticalOptions = LayoutOptions.FillAndExpand;
            var cont = new StackLayout();
            cont.Children.Add(_web);

            this.Content = cont;

            InitializeComponent();


            var web_source = new UrlWebViewSource
            {
                Url = "http://www.fb.com"
            };
            this.WebDisplay(web_source);

        }

        public void WebDisplay(UrlWebViewSource _source)
        {
            _web.Source = _source;
        }
    }
}
