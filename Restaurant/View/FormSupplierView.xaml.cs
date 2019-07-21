using Restaurant.DB;
using Restaurant.Model;
using Restaurant.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurant.View
{
    /// <summary>
    /// Lógica de interacción para FormSupplierView.xaml
    /// </summary>
    public partial class FormSupplierView : Window
    {
        public SupplierViewModel context = new SupplierViewModel();

        public FormSupplierView()
        {
            InitializeComponent();  
            DataContext = context;
            btnSaveSupplier.IsEnabled = false;
            context.Supplier.PropertyChanged += new PropertyChangedEventHandler(Supplier_PropertyChanged);
        }

        private void Supplier_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSaveSupplier.IsEnabled = context.Supplier.IsValid();

        }

        private void Btn_SaveSupplier(object sender, RoutedEventArgs e)
        {
            if (btnSaveSupplier.IsEnabled)
            {                       
                DateTime createdAt = DateTime.Now;
                var oSupplier = new SupplierModel();
                oSupplier.Name = txtName.Text;
                oSupplier.FirstSurname = txtFirstSurname.Text;
                oSupplier.SecondSurname = txtSecondSurname.Text;
                oSupplier.Phone = txtPhone.Text;
                oSupplier.Address = txtAddress.Text;
                oSupplier.CreatedAt = createdAt;
                if (SupplierViewModel.SaveSupplier(oSupplier))
                {
                    MessageBox.Show("Proveedor registrado exitosamente");
                    this.Close();   
                }
                else
                    MessageBox.Show("No se pudo registrar, intentelo de nuevo");
            }   
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }
    }
}
