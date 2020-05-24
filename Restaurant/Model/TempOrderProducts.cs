using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class TempOrderProducts: ObservableObject
    {
        public int _Id;
        public int Id           
        {
            get { return _Id; }
            set
            {
                if (_Id == value) return;
                _Id = value;
                OnPropertyChanged("Id");
            }
        }


        public string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name == value) return;
                _Name = value;
                OnPropertyChanged("Name");  
            }
        }
        public string _Description;
        public string Description       
        {
            get { return _Description; }
            set
            {
                if (_Description == value) return;
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public decimal _Price { get; set; }
        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (_Price == value) return;
                _Price = value;
                OnPropertyChanged("Price");
            }
        }

        public decimal? _Cost;
        public decimal? Cost
        {
            get { return _Cost; }
            set
            {
                if (_Cost == value) return;
                _Cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                if (_Quantity == value) return;
                _Quantity = value;
                OnPropertyChanged("Quantity");
            }   
        }

    }       
}
