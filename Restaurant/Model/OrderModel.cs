using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class OrderModel: ObservableObject
    {

        private DB.Orders model = new DB.Orders();
        public int Id
        {
            get { return model.Id; }
            set
            {
                if (model.Id == value) return;
                model.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public int Account
        {
            get { return model.AccountId; }
            set
            {
                if (model.AccountId == value) return;
                model.AccountId = value;
                OnPropertyChanged("Account");
            }
        }

        public int User
        {
            get { return model.UserId; }
            set
            {
                if (model.UserId == value) return;
                model.UserId = value;       
                OnPropertyChanged("User");
            }
        }

        public TimeSpan Hour
        {
            get { return model.Hour; }
            set
            {
                if (model.Hour == value) return;
                model.Hour = value;
                OnPropertyChanged("Hour");
            }
        }

        public int? People
        {
            get { return model.People; }
            set
            {
                if (model.People == value) return;
                model.People = value;
                OnPropertyChanged("People");
            }
        }

        public bool Status
        {
            get { return model.Status; }
            set
            {
                if (model.Status == value) return;
                model.Status = value;
                OnPropertyChanged("Status");
            }   
        }   

        public string Description
        {
            get { return model.Descripcion; }
            set
            {
                if (model.Descripcion == value) return;
                model.Descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }


        public int Type
        {
            get { return model.TypeId; }
            set
            {
                if (model.TypeId == value) return;
                model.TypeId = value;
                OnPropertyChanged("Type");
            }
        }

    }
}
