using Restaurant.DB;
using Restaurant.Model;
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
    /// Lógica de interacción para AccountView.xaml
    /// </summary>
    public partial class AccountView : Window
    {
        public AccountView()
        {
            InitializeComponent();          
            CargarBox();    
        }

        private void Btn_SaveAccount(object sender, RoutedEventArgs e)
        {

            DateTime OpenDate = DateTime.Now;
            if (Utility.Helpers.IsDecimal(txtQuantity.Text) > 0 && Utility.Helpers.IsInteger(txtBox.SelectedValue.ToString()) > 0)
            {
                var oAccount = new AccountModel();
                oAccount.User = LoginView.UserId;
                oAccount.Box = (int)txtBox.SelectedValue;
                oAccount.Status = true;
                oAccount.OpenDate = OpenDate;
                oAccount.Quantity = decimal.Parse(txtQuantity.Text);
                if (SaveAccount(oAccount))
                {
                    MessageBox.Show("Cuenta registrada correctamente");                         
                    this.Close();
                }
                else
                    MessageBox.Show("No se pudo registrar la cuenta, intentelo de nuevo.");
            }
            else
            {   
                MessageBox.Show("Ingrese un valores validos");      
            }

        }

        private static bool SaveAccount(AccountModel model) 
        {
            using (var db = new RestaurantTPVEntities())
            {
                var oAccount = new Accounts();
                oAccount.UserId     = model.User;
                oAccount.BoxId      = model.Box;
                oAccount.Status     = model.Status;
                oAccount.OpenDate   = model.OpenDate;
                oAccount.Quantity   = model.Quantity;
                db.Accounts.Add(oAccount);                     
                try
                {
                    return db.SaveChanges() > 0;
                }
                catch (Exception)
                {

                    return false;
                } 
                    
            }       
             
        }

        private void CargarBox()
        {            
            using (var db = new RestaurantTPVEntities())
            {
                txtBox.ItemsSource = db.Boxes.OrderBy(d => d.Number).ToList();
                txtBox.DisplayMemberPath = "Number";    
                txtBox.SelectedValuePath = "Id";
            }
        }

    //private bool IsNumeric(string num)
    //{
    //    try
    //    {
    //        decimal x = Convert.ToDecimal(num);
    //        return true;
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }
    //}

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
