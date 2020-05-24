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
    /// Lógica de interacción para OrderDetailView.xaml
    /// </summary>
    public partial class OrderDetailView : Window
    {       
        public OrderDetailView(OrderViewModel context)
        {       
            InitializeComponent();
            DataContext = context;                     
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();       
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }   
    }
}
