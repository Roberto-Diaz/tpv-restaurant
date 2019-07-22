using Restaurant.DB;
using Restaurant.Model;
using Restaurant.View;
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

namespace Restaurant
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _main = new MainViewModel();
        public static Frame StaticMainFrame;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;    
            StaticMainFrame = Main;                   
            //Refresh();
        }   
        private void Refresh()
        {   
          
            List<UserModel> lst = new List<UserModel>();

            using (RestaurantTPVEntities db = new RestaurantTPVEntities())
            {
                lst = (from d in db.Users
                       select new UserModel
                       {
                           Name = d.Name,
                           UserName = d.UserName,
                           Password = d.Password
                       }).ToList();
            }

            //datagrid.itemssource = lst;   
            //StaticMainFrame.Content = new SupplierView();
        }

        private void Selected_DinnerRoom(object sender, RoutedEventArgs e)
        {
            StaticMainFrame.Content = new DinnerRoomView();     
        }
    }
}
