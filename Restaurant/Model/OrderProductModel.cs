using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class OrderProductModel: ObservableObject
    {
        private DB.OrderProduct model = new DB.OrderProduct();
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

        public int Order
        {
            get { return model.OrderId; }
            set
            {
                if (model.OrderId == value) return;
                model.OrderId = value;
                OnPropertyChanged("OrderId");
            }
        }


        public int Product
        {
            get { return model.ProductId; }
            set
            {
                if (model.ProductId == value) return;
                model.ProductId = value;
                OnPropertyChanged("ProductId");
            }
        }

        public int Quantity
        {
            get { return model.Quantity; }
            set
            {
                if (model.Quantity == value) return;
                model.Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public decimal? UnitPrice
        {
            get { return model.UnitPrice; }
            set
            {
                if (model.UnitPrice == value) return;
                model.UnitPrice = value;
                OnPropertyChanged("UnitPrice");
            }           
        }

        public decimal? UnitCost
        {
            get { return model.UnitCost; }
            set
            {
                if (model.UnitCost == value) return;
                model.UnitCost = value;
                OnPropertyChanged("UnitCost");
            }
        }
    }
}
