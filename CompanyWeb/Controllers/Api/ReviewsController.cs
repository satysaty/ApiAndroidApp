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
    public class ReviewsController : ApiController
    {
        DataContext Data = new DataContext();

        // GET api/<controller>
        public IEnumerable<Review> Get()
        {
            return Data.Reviews.ToList();
        }

        // GET api/<controller>/5
        public Review Get(int id)
        {
            return Data.Reviews.Find(id);
        }
    } 
}