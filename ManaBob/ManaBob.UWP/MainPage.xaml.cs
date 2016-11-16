using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

using ManaBob.Services;

namespace ManaBob.UWP
{
    public sealed partial class MainPage
    {

        public MainPage()
        {
            this.InitializeComponent();
            var netSvc      = new ManaBob.Services.FakeNet();
            var localSvc    = new ManaBob.Services.FakeLocal();
            var authSvc     = new ManaBob.Services.FakeAuth();

            var Core = new ManaBob.AppCore(netSvc, localSvc, authSvc);
            LoadApplication(Core);
        }
        
    }
}
