using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Utility
{
    public class ObservableObject: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {       
            if (PropertyChanged != null)
            {       
                 PropertyChanged(this, new PropertyChangedEventArgs(propertyName));     
            }           

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }





        //protected void OnPropertyChanged(params string[] name)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        foreach (var n in name)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(n));
        //        }
        //    }
        //}   
    }
}
