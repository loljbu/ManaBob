using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;    // for INotifyPropertyChanged

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManaBob.Pages
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="https://developer.xamarin.com/api/type/Xamarin.Forms.TabbedPage/"/>
    public partial class RoomListPage : TabbedPage
    {
        Navigator   navi;
        Repository  pages;

        public RoomListPage(Navigator _navi, Repository _pages)
        {
            navi = _navi;
            pages = _pages;
            InitializeComponent();

            Menu[] menus = new Menu[]
            {
                new Menu("Red", Color.Red),
                new Menu("Green", Color.Green),
                new Menu("Blue", Color.Blue),
            };
            this.ItemsSource = menus;

            this.ItemTemplate = new DataTemplate(() => {
                return new ColorPage();
            });

        }
    }

    class Menu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private String  name;
        private Color   content;

        public Menu(String _name, Color _content)
        {
            this.name = _name;
            this.content = _content;
        }

        void OnPropertyChanged(String _property_name = null)
        {
            var handler = PropertyChanged;
            if(handler == null)
            {
                return;
            }
            handler(this, new PropertyChangedEventArgs(_property_name));
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Equals(this.name) == true)
                {
                    return;
                }
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public Color Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if(value.Equals(this.content) == true)
                {
                    return;
                }
                content = value;
                OnPropertyChanged("Content");
            }
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
    

    // Format page
    class ColorPage : ContentPage
    {
        public ColorPage()
        {
            // This binding is necessary to label the tabs in
            // the TabbedPage.
            this.SetBinding(ContentPage.TitleProperty, "Name");
            // BoxView to show the color.
            BoxView boxView = new BoxView
            {
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center
            };
            boxView.SetBinding(BoxView.ColorProperty, "Content");

            // Build the page
            this.Content = boxView;
        }
    }


}
