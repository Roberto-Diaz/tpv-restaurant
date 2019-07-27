using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModel
{
    public class OrderViewModel 
    {
        public OrderModel Order { get; private set; }
        public OrderViewModel()
        {
            Order = new OrderModel();   
        }
    }
}
