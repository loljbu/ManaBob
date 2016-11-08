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

namespace ManaBob.UWP
{
    public sealed partial class MainPage
    {

        public MainPage()
        {
            this.InitializeComponent();
            //LoadApplication(new ManaBob.AppCore());
        }

        //private void login_Click(object sender, RoutedEventArgs e)
        //{
        //    if (this.Frame.CanGoBack)
        //    {
        //        this.Frame.GoBack();
        //    }

        //    //this.Frame.Navigate(typeof(RoomView));
        //}

        //private void confirm_Click(object sender, RoutedEventArgs e)
        //{
        //    // 인증하기 위해 페북 사이트로 이동
        //}
    }
}
