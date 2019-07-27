using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class ProductModel: ObservableObject
    {
        private DB.Products model = new DB.Products();
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

        public int Category
        {
            get { return model.CategoryId; }
            set
            {
                if (model.CategoryId == value) return;
                model.CategoryId = value;
                OnPropertyChanged("Category");
            }
        }

        public int? Supplier
        {
            get { return model.SupplierId; }
            set
            {
                if (model.SupplierId == value) return;
                model.SupplierId = value;
                OnPropertyChanged("Supplier");
            }
        }

        public int? Measure
        {
            get { return model.MeasureId; }
            set
            {
                if (model.MeasureId == value) return;
                model.MeasureId = value;
                OnPropertyChanged("Measure");
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

        public string Image
        {
            get { return model.Image; }
            set
            {
                if (model.Image == value) return;
                model.Image = value;
                OnPropertyChanged("Image");
            }
        }

        public string Code
        {
            get { return model.Code; }
            set
            {
                if (model.Code == value) return;
                model.Code = value;
                OnPropertyChanged("Code");
            }
        }

        public decimal? Cost
        {
            get { return model.Cost; }
            set
            {
                if (model.Cost == value) return;
                model.Cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public decimal Price    
        {
            get { return model.Price; }
            set
            {
                if (model.Price == value) return;
                model.Price = value;
                OnPropertyChanged("Price");
            }
        }

        public int? Stock
        {
            get { return model.Stock; }
            set
            {
                if (model.Stock == value) return;
                model.Stock = value;
                OnPropertyChanged("Stock");
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

        public bool Inventory
        {
            get { return model.Inventory; }
            set
            {
                if (model.Inventory == value) return;
                model.Inventory = value;
                OnPropertyChanged("Inventory");
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

        public DateTime? UpdatedAt
        {   
            get { return model.UpdatedAt; }
            set
            {
                if (model.UpdatedAt == value) return;
                model.UpdatedAt = value;    
                OnPropertyChanged("UpdatedAt");
            }
        }   

    }
}
