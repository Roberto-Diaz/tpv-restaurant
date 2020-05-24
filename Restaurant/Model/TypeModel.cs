using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class TypeModel: ObservableObject
    {
        private DB.Types model = new DB.Types();
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

        public string Name
        {
            get { return model.Name; }
            set
            {
                if (model.Name == value) return;
                model.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool? Status
        {
            get { return model.Status; }
            set
            {
                if (model.Status == value) return;
                model.Status = value;
                OnPropertyChanged("Status");
            }
        }


        public DateTime? CreatedAt
        {
            get { return model.CreatedAt; }
            set
            {
                if (model.CreatedAt == value) return;
                model.CreatedAt = value;
                OnPropertyChanged("CreatedAt");
            }   
        }   
    }
}
