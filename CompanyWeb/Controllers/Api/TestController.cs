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
    public class TestController : ApiController
    {
        DataContext Data = new DataContext();

        [Route("api/tests")]
        public Test Get()
        {
            return new Test()
            {
                Id = 0,
                CityId = 0,
                //Name = "123",
                //Icon = "123",
                //Description = "123",
                //MainCategoryId = 0,
                //Works = new List<Work>()
               // {
                 //   new Work(),
                //    new Work(),
                //    new Work(),
                 //   new Work(),
                 //   new Work()
                //}
            };
        }
    }
}