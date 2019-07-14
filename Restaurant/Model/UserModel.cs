using Restaurant.DB;
using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class UserModel: ObservableObject
    {
        private Users model = new Users();      

        public string Name
        {
            get { return model.Name; }
            set
            {
                model.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string UserName
        {
            get { return model.UserName; }
            set
            {
                model.UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return model.Password; }
            set
            {
                model.Password = value;
                OnPropertyChanged("Password");
            }
        }

        public int Id { get; set; }
    }
}
