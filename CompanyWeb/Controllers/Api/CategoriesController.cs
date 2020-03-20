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
    public class CategoriesController : ApiController
    {
        DataContext Data = new DataContext();

        [Route("api/categories/{mainCategoryId}/{city}")]
        public IEnumerable<Category> Get(int mainCategoryId, int city)
        {
            return Data.Categories.Where(x => x.CityId == city).Where(x => x.MainCategoryId == mainCategoryId);
        }
    }
}