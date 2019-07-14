using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModel
{
    public class MainViewModel
    {
        public UserModel User { get; private set; } 
        //public SupplierModel Supplier { get; private set; }   
        public MainViewModel()
        {
            User = new UserModel();
            //Supplier = new SupplierModel();
        }
    }
}
