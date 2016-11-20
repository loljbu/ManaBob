using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.ComponentModel;

using Xamarin.Forms;
using ManaBob;

namespace ManaBob.Controls
{
    public class RoomViewCell : Xamarin.Forms.ViewCell
    {
        Image   img;
        String  title;
        String  detail;

        public RoomViewCell()
        {
        }


        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string _property = null)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(_property));
        //    }
        //}
    }
}
