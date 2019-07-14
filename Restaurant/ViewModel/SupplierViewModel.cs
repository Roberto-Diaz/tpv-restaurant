using Restaurant.Model;
using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant.ViewModel
{
    public class SupplierViewModel
    {
        public RelayCommand SaveCommandSupplier { get; private set; }           
        public SupplierModel Supplier { get; private set; }     

        public SupplierViewModel()  
        {       
            Supplier = new SupplierModel();             
            SaveCommandSupplier = new RelayCommand(SaveSupplierExecute, SaveSupplierCanExecute);
        }

        public void SaveSupplierExecute()
        {
            MessageBox.Show("Proveedor guardado");
        }   
        public bool SaveSupplierCanExecute(object parameter)
        {

            var values = (object[])parameter;
            if (string.IsNullOrEmpty((string)values[0]) || string.IsNullOrEmpty((string)values[1]))
                return false;
            else
                return true;
        }
    }
}
