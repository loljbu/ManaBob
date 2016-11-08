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

        public AppCore()
        {
            // Net/Local services
            // ---- ---- ---- ---- ----

            svc.Register<IAuthService>(new FakeAuth());
            svc.Register<INetService>(new FakeNet());
            svc.Register<ILocalService>(new FakeLocal());


            // Pages / Navigation
            // ---- ---- ---- ---- ----

            navi = new Navigator(this);

            var intro = new IntroPage(navi, pages);
            var login = new LoginPage(navi, pages);
            var rlist = new RoomListPage(navi, pages);
            var webvw = new WebPage(navi, pages);

            pages.Register<IntroPage>(intro);
            pages.Register<LoginPage>(login);
            pages.Register<RoomListPage>(rlist);
            pages.Register<WebPage>(webvw);

            this.MainPage = new NavigationPage(intro);
        }

        protected override void OnStart()
        {
            // The root page of your application
            var page = pages.Resolve<IntroPage>();
            if(page == null) { return; }
            var next = new NavigationPage(page);
            navi.GoAsyncTo(next);
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
