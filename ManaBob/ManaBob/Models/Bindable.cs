using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ManaBob
{
    /// <summary>
    ///     Data Binding base class
    /// </summary>
    /// <seealso cref="INotifyPropertyChanged"/>
    /// <seealso cref="PropertyChangedEventHandler"/>
    public class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string _property = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_property));
            }
        }
    }
}
