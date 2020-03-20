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
    public class OptionsController : ApiController
    {
        DataContext Data = new DataContext();

        //[Route("api/options/{workId}/{cityId}")]
        //public IEnumerable<Option> Get(int workId, int cityId)
        //{
        //    //return Data.Options.Include(p=> p.WorkOption).Where(x => x.CityId == cityId).Where(x => x.WorkId == workId).ToList();
        //}

        // GET api/<controller>/5
       // public Option Get(int id)
       // {
         //   return Data.Repairs.Find(id);
       // }
    } 
}