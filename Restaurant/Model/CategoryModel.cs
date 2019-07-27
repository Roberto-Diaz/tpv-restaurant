using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class CategoryModel: ObservableObject
    {
        private DB.Categories model = new DB.Categories();
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

        public string Description
        {
            get { return model.Description; }
            set
            {
                if (model.Description == value) return;
                model.Description = value;
                OnPropertyChanged("Description");   
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
