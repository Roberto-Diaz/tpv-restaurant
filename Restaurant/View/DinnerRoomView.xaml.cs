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
    /// Lógica de interacción para DinnerRoomView.xaml
    /// </summary>
    public partial class DinnerRoomView : Page
    {
        public DinnerRoomViewModel context = new DinnerRoomViewModel();
        public DinnerRoomView()
        {           
            InitializeComponent();
            DataContext = context;
        }

        private void Btn_ShowArea(object sender, RoutedEventArgs e)
        {
            string nombre = ((Button)e.Source).Content.ToString();
            int id = int.Parse(((Button)e.Source).Uid); 
            MessageBox.Show(""+ id);             
        }

        private void Btn_OpenTable(object sender, RoutedEventArgs e)
        {
            string nombre = ((Button)e.Source).Content.ToString();
            int id = int.Parse(((Button)e.Source).Uid);

            OrderView _order = new OrderView();
            _order.Mesa.Text = id.ToString();
            _order.User.Text = LoginView.usuario;

            MainWindow.StaticMainFrame.Content = _order;    

            //FormOrderView _formOrder = new FormOrderView();
            //_formOrder.Mesa.Text = id.ToString();
            //_formOrder.User.Text = LoginView.usuario;           
            //_formOrder.Show();  
        }
    }
}
