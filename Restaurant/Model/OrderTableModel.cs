using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class OrderTableModel: ObservableObject
    {
        private DB.OrderTable model = new DB.OrderTable();
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

        public int Orden
        {
            get { return model.OrdenId; }
            set
            {
                if (model.OrdenId == value) return;
                model.OrdenId = value;
                OnPropertyChanged("Orden");
            }
        }

        public int Table
        {
            get { return model.TableId; }
            set
            {
                if (model.TableId == value) return;
                model.TableId = value;
                OnPropertyChanged("Table");
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

    }
}
