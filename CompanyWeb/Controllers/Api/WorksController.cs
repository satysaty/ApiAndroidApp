using CompanyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyWeb.Controllers
{
    public class WorksController : ApiController
    {
        DataContext Data = new DataContext();

        [Route("api/works/{categoryId}/{city}")]
        public IEnumerable<Work> Get(int categoryId, int city)
        {
            return Data.Categories.Where(x => x.Id == categoryId).Where(x => x.CityId == city).SelectMany(x => x.Works).Include(p=>p.Masters).ToList();
        }

        //public class CategoriesController : ApiController
        //{
        //    DataContext Data = new DataContext();

        //    [Route("api/categories/{mainCategoryId}/{city}")]
        //    public IEnumerable<Work> Get(int mainCategoryId, int city)
        //    {
        //        //var s = new Category();
        //        // s.Name = "Category1";
        //        //// s.Works = new List<Work>() { new Work() { Name = "Work1" },
        //        // new Work() { Name = "Work2" },
        //        // new Work() { Name = "Work3" }};
        //        //  Data.Categories.Add(s);
        //        //  Data.SaveChanges();
        //        //var st1 = Data.Categories.Include(x=>x.Works).FirstOrDefault().Works;
        //        //var st = Data.Categories.Where(x => x.Id == 1).SelectMany(x => x.Works);
        //        return Data.Categories.Where(x => x.Id == 1).SelectMany(x => x.Works);
        //    }
        //} 
    }
}