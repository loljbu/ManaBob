using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using ManaBob.ViewModel;

namespace ManaBob
{
    public class AppCore : Application
    {
        // Net/Local services
        IService svc;

        ContentPage _intro  = new Pages.IntroPage();
        // ContentPage _login  = new Pages.LoginPage();
        // ContentPage _web    = new Pages.WebPage();

        public AppCore()
        {
            // The root page of your application
            MainPage = new NavigationPage(_intro);
        }

        // - Note
        //      Exit the Core. Release all resources
        public void exit()
        {
            // ...
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
