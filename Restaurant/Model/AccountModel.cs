using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    class AccountModel: ObservableObject    
    {
        private DB.Accounts model = new DB.Accounts();
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
        public int User
        {
            get { return model.UserId; }
            set
            {
                if (model.UserId == value) return;
                model.UserId = value;
                OnPropertyChanged("User");
            }
        }

        public int Box
        {
            get { return model.BoxId; }
            set
            {
                if (model.BoxId == value) return;
                model.BoxId = value;
                OnPropertyChanged("Box");
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
        public DateTime OpenDate
        {
            get { return model.OpenDate; }
            set
            {
                if (model.OpenDate == value) return;
                model.OpenDate = value;
                OnPropertyChanged("OpenDate");
            }
        }

        public decimal Quantity
        {
            get { return model.Quantity; }
            set
            {
                if (model.Quantity == value) return;
                model.Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        public DateTime? CloseDate
        {
            get { return model.CloseDate; }
            set
            {
                if (model.CloseDate == value) return;
                model.CloseDate = value;
                OnPropertyChanged("CloseDate");
            }
        }   

        //public string Error
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        return IsValid(columnName);
        //    }
        //}

        //private string IsValid(string propertyName)

        //{
        //    string result = null;
        //    switch (propertyName)
        //    {
        //        case "Box":
        //            if (Box.ToString().Length > 0)
        //                result = "La caja es obligatoria";
        //            break;
        //        case "Quantity":
        //            if (string.IsNullOrEmpty(Quantity.ToString()))
        //                result = "La cantidad es obligatoria";
        //            break;
        //    }
        //    return result;

        //}

        //public bool IsValid()
        //{

        //    return string.IsNullOrEmpty(IsValid("Name")) && string.IsNullOrEmpty(IsValid("FirstSurname")) &&
        //           string.IsNullOrEmpty(IsValid("SecondSurname")) && string.IsNullOrEmpty(IsValid("Phone")) &&
        //           string.IsNullOrEmpty(IsValid("Address"));

        //}

    }
}
