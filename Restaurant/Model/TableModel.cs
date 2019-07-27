using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class TableModel: ObservableObject
    {
        private DB.Tables model = new DB.Tables();
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

        public int Area
        {
            get { return model.AreasId; }
            set
            {
                if (model.AreasId == value) return;
                model.AreasId = value;
                OnPropertyChanged("Area");
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

        private string _StatusMenssage;
        public string StatusMenssage
        {
            get
            {
                if (model.Status == true)
                    return "Disponible";    
                else
                    return "Ocupada";
                    
            }   
            set
            {               
                if (_StatusMenssage == value) return;
                _StatusMenssage = value; 
                OnPropertyChanged("StatusMenssage");
            }       
        }

        private string _StatusColor;
        public string StatusColor
        {
            get
            {
                if (model.Status == true)
                    return "Green";
                else
                    return "Red";

            }
            set         
            {
                if (_StatusColor == value) return;
                _StatusColor = value;
                OnPropertyChanged("StatusColor");
            }
        }

        public Byte? Chairs
        {
            get { return model.Chairs; }
            set
            {
                if (model.Chairs == value) return;
                model.Chairs = value;
                OnPropertyChanged("Chairs");
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
