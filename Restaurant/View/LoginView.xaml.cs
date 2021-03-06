using Restaurant.DB;
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
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private int bandera = 0;
        public static string usuario;
        public static int UserId;
        public LoginView()
        {
            InitializeComponent();  
            usuario = "";       
        }

        
        private void BtnIniciar(object sender, RoutedEventArgs e)
        {

            using (RestaurantTPVEntities db = new RestaurantTPVEntities())
            {
                var user = (from d in db.Users
                            where d.UserName == txtUserName.Text && d.Password == txtPassword.Password
                            select d).FirstOrDefault();
                if (user != null)
                {
                    usuario = user.Name+" "+user.FirstSurname+" "+user.SecondSurname;
                    UserId = user.Id;                  
                    bandera = 1;    
                }
                else
                    MessageBox.Show("Datos invalidos");
            }
            //bandera = 1;          
            if (bandera == 1)
            {
                //var model = new Model.Users();
                //var viewModel = new ViewModel.UserViewModel { };
                //var view = new MainWindow { DataContext = viewModel };
                //view.Show();          
                MainWindow _main = new MainWindow();
                //_main.bienvenido.Text = usuario;          
                        
                _main.Show();
                Close();        
            }
        }

        private void BtnCerrarLogin(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BorderMouseLeftButtonDownLogin(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
