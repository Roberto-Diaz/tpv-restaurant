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
        }
        
        private void Btn_SaveSupplier(object sender, RoutedEventArgs e)
        {
                        
        }
    }
}
