using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using ManaBob.Services;
using ManaBob.ViewModel;
using ManaBob.Pages;

namespace ManaBob
{
    /// <summary>
    ///     Navigation Handler for Xamarin.Forms application
    /// </summary>
    /// <dependency>
    ///     Xamarin.Forms.Application
    /// </dependency>
    public class Navigator
    {
        Xamarin.Forms.Application app;

        public Navigator(Xamarin.Forms.Application _app)
        {
            if(_app == null)
            {
                throw new ArgumentNullException();
            }
            this.app = _app;
        }

        public void GoAsyncTo(NavigationPage _next)
        {
            if (_next == null) { return; }
            app.MainPage = _next;
        }

        public async void PushAsyncTo(NavigationPage _next)
        {
            if (_next == null) { return; }
            await app.MainPage.Navigation.PushAsync(_next);
        }

        public async void PopAsync()
        {
            if(CanGoBack == false){ return; }
            await app.MainPage.Navigation.PopAsync();
        }

        public bool CanGoBack
        {
            get
            {
                return app.MainPage.Navigation.NavigationStack.Count != 0;
            }
        }

    }
}
