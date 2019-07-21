using Restaurant.DB;
using Restaurant.Model;
using Restaurant.Utility;
using Restaurant.View;
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
            //SaveCommandSupplier = new RelayCommand(SaveSupplierExecute, SaveSupplierCanExecute);
        }

        public void SaveSupplierExecute(object parameter)
        {
            MessageBox.Show("ok");                           
        }   
        public bool SaveSupplierCanExecute(object parameter)
        {

            var values = (object[])parameter;
            if (string.IsNullOrEmpty((string)values[0]) || string.IsNullOrEmpty((string)values[1]))
                return false;
            else
                return true;
        }                   

        public static bool SaveSupplier(SupplierModel model)
        {
            using (var db = new RestaurantTPVEntities())
            {
                var oSupplier = new Suppliers();
                oSupplier.Name = model.Name;
                oSupplier.FirstSurname = model.FirstSurname;
                oSupplier.SecondSurname = model.SecondSurname;
                oSupplier.Phone = model.Phone;
                oSupplier.Address = model.Address;
                oSupplier.CreatedAt = model.CreatedAt;
                db.Suppliers.Add(oSupplier);
                return db.SaveChanges() > 0;
            }
        }
    }
}
