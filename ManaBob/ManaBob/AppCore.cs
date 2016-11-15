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
        Repository repo = new Repository();

        public AppCore()
        {
            // Net/Local services
            repo.Register<IAuthService>(new FakeAuth());
            repo.Register<INetService>(new FakeNet());
            repo.Register<ILocalService>(new FakeLocal());

            // Pages
            repo.Register<IntroPage>(new IntroPage(this));
            repo.Register<LoginPage>(new LoginPage(this));
            repo.Register<RoomListPage>(new RoomListPage(this));
            repo.Register<WebPage>(new WebPage(this));


            // The root page of your application
            var main = repo.Resolve<IntroPage>();
            this.NavigateTo(main);
        }

        public Repository Repo
        {
            get{ return repo; }
        }

        public void NavigateTo(Page _next)
        {
            if(_next == null) { return; }
            this.MainPage = new NavigationPage(_next);
        }

        public async void PushTo(Page _next)
        {
            if (_next == null) { return; }
            var navPage = new NavigationPage(_next);
            await this.MainPage.Navigation.PushAsync(navPage);
        }

        public async void Pop()
        {
            await this.MainPage.Navigation.PopAsync();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

}// namespace ManaBob
