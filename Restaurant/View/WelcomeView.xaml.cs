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
    /// Lógica de interacción para WelcomeView.xaml
    /// </summary>
    public partial class WelcomeView : Page
    {
        public WelcomeView()
        {
            InitializeComponent();
            welcome.Content = LoginView.usuario;    
        }

        private void Btn_OpenAccount(object sender, RoutedEventArgs e)
        {
            AccountView _Account = new AccountView();
            _Account.Show();    
        }
    }
}
