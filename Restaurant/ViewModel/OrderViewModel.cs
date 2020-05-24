using Restaurant.DB;
using Restaurant.Model;
using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Restaurant.ViewModel
{
    public class OrderViewModel: ObservableObject
    {
        public OrderModel Order { get; private set; }                    
        public List<CategoryModel> lstCategories { get; private set; }          
                
        private ObservableCollection<TempOrderProducts> _LstOrderProduct;                               
        public ObservableCollection<TempOrderProducts> lstOrderProduct
        {       
            get
            {
                if (null == _LstOrderProduct)
                    _LstOrderProduct = new ObservableCollection<TempOrderProducts>();                   

                return _LstOrderProduct;
            }
            set
            {
                if (_LstOrderProduct == value) return;
                _LstOrderProduct = value;
                OnPropertyChanged("lstOrderProduct");
            }
        }

        private TempOrderProducts _SelectedItem = null;
        public TempOrderProducts selectedItem
        {
            get
            {
                return _SelectedItem;   
            }
            set
            {
                if (_SelectedItem == value) return;
                _SelectedItem = value;
                OnPropertyChanged();
            }

        }

        //public TempOrderProducts selectedItem { get; set; }
                   
                
        //Metodo creado para agregar todos los productos a una lista ObservableCollection temporal que contendra
        //todos los productos de la orden. 
        public void AddOrderProduct(ProductModel item)      
        {       
            var oOrderProduct = new TempOrderProducts();

            oOrderProduct.Id = item.Id;
            oOrderProduct.Name = item.Name; 
            oOrderProduct.Cost = item.Cost;
            oOrderProduct.Price = item.Price;   
            oOrderProduct.Quantity = 1;         


            var rest = lstOrderProduct.Where(x => x.Id == oOrderProduct.Id).FirstOrDefault();   

            if (rest != null)
            {
                rest.Quantity ++;
                rest.Price += item.Price;                               
                //oOrderProduct.Quantity = rest.Quantity + 1;        
                //var x = lstOrderProduct.IndexOf(rest);
                //lstOrderProduct.RemoveAt(x);                    
                //lstOrderProduct.Insert(x, oOrderProduct);
            }   
            else
            {
                lstOrderProduct.Add(oOrderProduct); 
            }   

        }
   
        private ObservableCollection<ProductModel> _LstProducts;
        public ObservableCollection<ProductModel> lstProducts
        {
            get
            {
                if (null == _LstProducts)
                    _LstProducts = new ObservableCollection<ProductModel>(GetProducts());

                return _LstProducts;
            }       
            set         
            {
                if (_LstProducts == value) return;
                _LstProducts = value;
                OnPropertyChanged("lstProducts");
            }
        }

        private RelayCommand _ShowCommandProducts;
        public RelayCommand showCommandProducts
        {
            get
            {
                if (null == _ShowCommandProducts)
                    _ShowCommandProducts = new RelayCommand(ShowProductsExecute, ShowProductsCanExecute);

                return _ShowCommandProducts;
            }
            set
            {
                _ShowCommandProducts = value;
            }
        }

        //Command creado para abrir un vista con detalle del item /producto seleccionado.
        private RelayCommand _OrderDetailCommand;
        public RelayCommand orderDetailCommand
        {   
            get
            {
                if (null == _OrderDetailCommand)
                    _OrderDetailCommand = new RelayCommand(OrderDetailExecute, OrderDetailCanExecute);

                return _OrderDetailCommand;
            }
            set
            {
                _OrderDetailCommand = value;
            }
        }

        public RelayCommand addKeyboardCommand { get; set; }

        public RelayCommand selectedCommand { get; private set; }       

        public OrderViewModel()
        {
            Order = new OrderModel();            
            lstCategories = GetCategories();
            //selectedCommand = new RelayCommand(selectedExecute, selectedCanExecute);                 
            addKeyboardCommand = new RelayCommand(addKeyboardExecute, addKeyboardCanExecute);
        }

        //private void selectedExecute(object parameter)
        //{
        //    selectedItem = null;
        //}

        //private bool selectedCanExecute(object parameter)
        //{   
        //    return selectedItem != null;
        //}     
                    
        private List<CategoryModel> GetCategories()
        {
            List<CategoryModel> lst = new List<CategoryModel>();
            using (var db = new RestaurantTPVEntities())
            {
                lst = db.Categories.Select(x => new CategoryModel
                {
                    Id = x.Id,
                    Restaurant = x.RestaurantId,
                    Name = x.Name,
                    Description = x.Description,
                    Color = x.Color,
                    CreatedAt = x.CreatedAt
                }).ToList();
                        
            }       
            return lst; 
        }   

        private List<ProductModel> GetProducts()
        {
            List<ProductModel> lst = new List<ProductModel>();           
            using (var db = new RestaurantTPVEntities())
            {
                lst = db.Products.Select(x => new ProductModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Image = x.Image,
                    Cost = x.Cost,
                    Price = x.Price,
                    Stock = x.Stock,
                    Status = x.Status,
                    Inventory = x.Inventory,
                    CreatedAt = x.CreatedAt
                }).ToList();
            
            }
            return lst;
        }
            
        public void GetProductsForId(int id)
        {       
            List<ProductModel> lst = new List<ProductModel>();
            using (var db = new RestaurantTPVEntities())
            {
                lst = db.Products.Select(x => new ProductModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Image = x.Image,
                    Cost = x.Cost,
                    Price = x.Price,
                    Stock = x.Stock,
                    Status = x.Status,
                    Inventory = x.Inventory,
                    CreatedAt = x.CreatedAt
                }).Where(x => x.Id == id).ToList();

            }
            //_LstProducts.Clear(); 
                        
            lstProducts = new ObservableCollection<ProductModel>(lst);                         

        }

        

        public void ShowProductsExecute(object parameter)
        {
            int id = (int)parameter;
            //MessageBox.Show("" + id);           
            //lstProducts = GetProductsForId(id);               
            GetProductsForId(id);
        }   
        public bool ShowProductsCanExecute(object parameter)
        {         
            return true;
            //int value = (int)parameter;

            //if (Helpers.IsInteger(value.ToString()) > 0)
            //    return true;
            //else
            //    return false;

        }

        public void OrderDetailExecute(object parameter)
        {
            int id = (int)parameter;            
             
            selectedItem = lstOrderProduct.Where(x => x.Id == id).FirstOrDefault();                
            View.OrderDetailView _orderDetailView = new View.OrderDetailView(this);     
            //var rest = lstOrderProduct.Where(x => x.Id == id).ToList();                       
            _orderDetailView.Show();        
            //var rest = lstOrderProduct.Where(x => x.Id == id).FirstOrDefault();

            //_orderDetailView.txtName.Text = rest.Name;    
            //_orderDetailView.txtPrice.Text = rest.Price.ToString();                   


            //_orderDetailView.txtDescription.Text = rest.Description;
            //_orderDetailView.Show();            
            //_orderDetailView.lstDetailOrderProduct.ItemsSource = new ObservableCollection<TempOrderProducts>(rest);

        }

        public bool OrderDetailCanExecute(object parameter)
        {
            //var value = (string)parameter;      
            Boolean  b =  false;    
            if (parameter != null)
            {
                var id = (int)parameter;
                b = true;       
            }

            return b;       
                                      
            //if (Helpers.IsInteger(parameter.ToString()) > 0)
            //    return true;
            //else
            //    return false;

        }

        public bool addKeyboardCanExecute(object parameter)
        {
            Boolean b = false;
            if (parameter != null)
            {
                //var id = (int)parameter;  
                b = true;
            }

            return b;
        }

        public void addKeyboardExecute(object parameter)
        {   
            //View.OrderDetailView _o = new View.OrderDetailView(this);
            var value = (string)parameter;
            if (value == "delete")   
            {       
                if (selectedItem.Description.Length > 0)            
                    selectedItem.Description = selectedItem.Description.Remove(selectedItem.Description.Length - 1);                
            }
            else
            {
                selectedItem.Description += value;                                  
            }
                
        }



    }
}
