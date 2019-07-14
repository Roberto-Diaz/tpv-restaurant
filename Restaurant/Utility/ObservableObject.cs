using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Utility
{
    public class ObservableObject: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(params string[] name)
        {
            if (PropertyChanged != null)
            {
                foreach (var n in name)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(n));
                }
            }
        }   
    }
}
