using Restaurant.DB;
using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class SupplierModel: ObservableObject, IDataErrorInfo
    {
        private Suppliers model = new Suppliers();              
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
                OnPropertyChanged("Name", "FullName");
            }
        }

        public string FullName
        {
            get { return model.Name + " " + model.FirstSurname + " " + model.SecondSurname; }
        }

        public string FirstSurname
        {
            get { return model.FirstSurname; }
            set
            {
                if (model.FirstSurname == value) return;
                model.FirstSurname = value;
                OnPropertyChanged("FirstSurname", "FullName");
            }
        }

        public string SecondSurname
        {
            get { return model.SecondSurname; }
            set
            {
                if (model.SecondSurname == value) return;
                model.SecondSurname = value;
                OnPropertyChanged("SecondSurname", "FullName");
            }
        }
        public string Phone
        {
            get { return model.Phone; }
            set
            {
                if (model.Phone == value) return;
                model.Phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Address
        {
            get { return model.Address; }
            set
            {
                if (model.Address == value) return;
                model.Address = value;
                OnPropertyChanged("Address");
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

        public string Error
        {
            get
            {
                return null;
            }
        }
                      
        public string this[string columnName]
        {
            get
            {   
                return IsValid(columnName);
            }       
        }
            
        private string IsValid(string propertyName)

        {
            string result = null;
            switch (propertyName)
            {
                case "Name":
                    if (string.IsNullOrWhiteSpace(Name))
                        result = "El nombre es obligatorio";
                    else if (Name.Length <= 3)
                        result = "Ingrese minimo 3 caracteres";
                    break;
                case "FirstSurname":
                    if (string.IsNullOrWhiteSpace(FirstSurname))
                        result = "El apellido es obligatorio";  
                    else if (FirstSurname.Length <= 3)          
                        result = "Ingrese minimo 3 caracteres";
                    break;
            }   
            return result;

        }   

        public bool IsValid()       
        {
        
            return string.IsNullOrEmpty(IsValid("Name")) && string.IsNullOrEmpty(IsValid("FirstSurname")) &&
                   string.IsNullOrEmpty(IsValid("SecondSurname")) && string.IsNullOrEmpty(IsValid("Phone")) &&
                   string.IsNullOrEmpty(IsValid("Address"));        

        }

    }
}
