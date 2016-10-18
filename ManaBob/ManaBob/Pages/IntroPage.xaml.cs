using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ManaBob.Pages
{
    public partial class IntroPage : ContentPage
    {
        Label WelcomeLabel;
        Button ChangeButton;

        public IntroPage()
        {
            ChangeButton = new Button { Text = "Click Me!" };
            WelcomeLabel = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to IntroPage!"
            };
            ChangeButton.Clicked += OnLabelTapped;


            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    WelcomeLabel,
                    ChangeButton
                }
            };
            //InitializeComponent();
        }

        private void OnLabelTapped(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "???";
        }

    }
}
