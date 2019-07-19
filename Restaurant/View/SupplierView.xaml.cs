using Restaurant.DB;
using Restaurant.Model;
using Restaurant.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restaurant.View
{
    /// <summary>
    /// Lógica de interacción para SupplierView.xaml
    /// </summary>
    public partial class SupplierView : Page
    {
        MainViewModel _main = new MainViewModel();
        List<SupplierModel> _listSupplier = new List<SupplierModel>();
        public SupplierView()
        {
            InitializeComponent();
            DataContext = _main;
            GetSuppliers(); 
        }       

        private void GetSuppliers()
        {
            //var prueba = ViewModel.SupplierViewModel.Pruebass();
            //dgSuppliers.ItemsSource = prueba;
            using (var db = new RestaurantTPVEntities())
            {
                _listSupplier = db.Suppliers.Select(x => new SupplierModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    FirstSurname = x.FirstSurname,
                    SecondSurname = x.SecondSurname,
                    Phone = x.Phone,
                    Address = x.Address,
                    CreatedAt = x.CreatedAt
                }).ToList();

            }
            dgSuppliers.ItemsSource = _listSupplier;
        }

        private void Btn_AddSupplier(object sender, RoutedEventArgs e)
        {
            //MainWindow.StaticMainFrame.Content = new FormSupplierView();        
            FormSupplierView _form = new FormSupplierView();
            _form.Show();   
            
        }
    }
}
