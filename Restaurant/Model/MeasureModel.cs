using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class MeasureModel: ObservableObject
    {
        private DB.Measures model = new DB.Measures();
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

        public string ShortName
        {
            get { return model.ShortName; }
            set
            {
                if (model.ShortName == value) return;
                model.ShortName = value;
                OnPropertyChanged("ShortName");
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

        public int Unity
        {
            get { return model.Unity; }
            set
            {
                if (model.Unity == value) return;
                model.Unity = value;    
                OnPropertyChanged("Unity");
            }
        }       
    }
}
