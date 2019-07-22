using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class AreasModel: ObservableObject
    {
        private DB.Areas model = new DB.Areas();
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

        public int Restaurant
        {
            get { return model.RestaurantId; }
            set
            {
                if (model.RestaurantId == value) return;
                model.RestaurantId = value;
                OnPropertyChanged("Restaurant");
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

        public string Color
        {
            get { return model.Color; }
            set
            {
                if (model.Color == value) return;
                model.Color = value;
                OnPropertyChanged("Color");
            }
        }

        public DateTime CreatedAt
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
