using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob
{
    /// <summary>
    ///     Navigation Handler for Xamarin.Forms application
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Application"/>
    /// <seealso cref="Xamarin.Forms.NavigationPage"/>
    public class Navigator
    {
        Xamarin.Forms.Application app;

        /// <summary>
        ///     Select the app to control navigation
        /// </summary>
        /// <seealso cref="Xamarin.Forms.Application"/>
        public Navigator(Xamarin.Forms.Application _app)
        {
            if(_app == null)
            {
                throw new ArgumentNullException();
            }
            this.app = _app;
        }

        /// <summary>
        ///     Directly move to the given page
        /// </summary>
        /// <seealso cref="Xamarin.Forms.NavigationPage"/>
        public void GoAsyncTo(NavigationPage _next)
        {
            if (_next == null) { return; }
            app.MainPage = _next;
        }

        /// <summary>
        ///     Use stack to move to the given page
        /// </summary>
        /// <seealso cref="Xamarin.Forms.NavigationPage"/>
        public async void PushAsyncTo(NavigationPage _next)
        {
            if (_next == null) { return; }
            await app.MainPage.Navigation.PushAsync(_next);
        }

        /// <summary>
        ///     Recover the previous page in the stack
        /// </summary>
        public async void PopAsync()
        {
            if(CanGoBack == false){ return; }
            await app.MainPage.Navigation.PopAsync();
        }

        /// <summary>
        ///     Check the stack depth
        /// </summary>
        public bool CanGoBack
        {
            get
            {
                return app.MainPage.Navigation.NavigationStack.Count > 0;
            }
        }

    }
}
