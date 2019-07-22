using Restaurant.DB;
using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModel
{
    public class DinnerRoomViewModel
    {
        public AreasModel Area { get; private set; }
        public List<AreasModel> lstAreas { get; private set; }
        public List<TableModel> lstTables { get; private set; }
            
        public DinnerRoomViewModel()
        {
            Area = new AreasModel();
            lstAreas = GetAreas();
            lstTables = GetTables();            
        }           

        private List<AreasModel> GetAreas()
        {
            List<AreasModel> lst = new List<AreasModel>();
            using (var db = new RestaurantTPVEntities())
            {
                lst = db.Areas.Select(x => new AreasModel
                {
                    Id = x.Id,  
                    Restaurant = x.RestaurantId,
                    Status = x.Status,
                    Name = x.Name,
                    Color = x.Color,
                    CreatedAt = x.CreatedAt
                }).ToList();
                        
            }   
            return lst;               
        }

        private List<TableModel> GetTables()  
        {           
            List<TableModel> lst = new List<TableModel>();
            using (var db = new RestaurantTPVEntities())
            {   
                lst = db.Tables.Select(x => new TableModel
                {
                    Id = x.Id,
                    Area = x.AreasId,
                    Status = x.Status,
                    Name = x.Name,
                    Chairs = x.Chairs,
                    CreatedAt = x.CreatedAt
                }).ToList();        
            }      
            return lst;
        }   

        //private List<TableModel> GetTablesDinnerRoom()
        //{
        //    List<TableModel> lst = new List<TableModel>();
        //    int firstArea = 0;
        //    using (var db = new RestaurantTPVEntities())
        //    {
        //        var area = db.Areas.Select(x => new AreasModel
        //        {
        //            Id = x.Id,
        //            Restaurant = x.RestaurantId,
        //            Status = x.Status,
        //            Name = x.Name,
        //            Color = x.Color,
        //            CreatedAt = x.CreatedAt
        //        }).First();
        //        firstArea = area.Id;
        //    }
        //}

    }
}
