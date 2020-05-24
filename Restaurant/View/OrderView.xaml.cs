using Restaurant.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para OrderView.xaml
    /// </summary>
    public partial class OrderView : Page
    {
        public OrderViewModel context = new OrderViewModel();               
        public OrderView()
        {   
            InitializeComponent();
            
            DataContext = context;                 
                         
        }

        private void BtnAddOrderProduct(object sender, RoutedEventArgs e)
        {
            Model.ProductModel  item = (Model.ProductModel)(sender as Button).DataContext;
            context.AddOrderProduct(item);                                              
            //var rest = c.Where(x => x.Id == oProduct.Id);           
        }

        private void BtnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {   
            MessageBox.Show("CLICK");       
        }
    }
}
