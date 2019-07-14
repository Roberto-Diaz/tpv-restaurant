using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModel
{
    public class LoginViewModel
    {
        public UserModel User { get; private set; }
        public LoginViewModel()
        {
            User = new UserModel(); 
        }
    }
}
