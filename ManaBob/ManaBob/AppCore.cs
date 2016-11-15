using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using ManaBob.Services;
using ManaBob.ViewModel;
using ManaBob.Pages;

namespace ManaBob
{
    public class AppCore : 
            Xamarin.Forms.Application
    {
        Repository svc   = new Repository();
        Repository pages = new Repository();

        Navigator navi;

        public AppCore(INetService _net, ILocalService _local, IAuthService _auth)
        {
            // Net/Local services
            // ---- ---- ---- ---- ----

            svc.Register<INetService>(_net);
            svc.Register<ILocalService>(_local);
            svc.Register<IAuthService>(_auth);


            // Pages / Navigation
            // ---- ---- ---- ---- ----

            navi = new Navigator(this);

            var intro = new ChatRoom(navi, pages);
            pages.Register<ChatRoom>(intro);


            // Mandatory for Framework's initialization
            this.MainPage = new NavigationPage(intro);
        }

        protected override void OnStart()
        {
            //// The root page of your application
            //var page = pages.Resolve<IntroPage>();
            //if(page == null) { return; }
            //var next = new NavigationPage(page);
            //navi.GoAsyncTo(next);
            this.MainPage.DisplayAlert("OnStart", "Starting!", "accept", "cancel");
        }

        protected override void OnSleep()
        {
            //this.MainPage.DisplayAlert("OnSleep", "sleeping", "accept", "cancel");
        }

        protected override void OnResume()
        {
            this.MainPage.DisplayAlert("OnResume", "resumed", "accept", "cancel");
        }
    }

}// namespace ManaBob
