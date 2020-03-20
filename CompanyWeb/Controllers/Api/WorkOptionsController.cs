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
    public class WorkOptionsController : ApiController
    {
        DataContext Data = new DataContext();

        [Route("api/workoptions/{workId}/{cityId}")]
        public IEnumerable<WorkOption> Get(int workId, int cityId)
        {
            return Data.Works.Where(x => x.Id == workId).Where(x => x.CityId == cityId).SelectMany(x => x.WorkOptions).Include(x=>x.Options); 
            //return Data.WorkOptions.Where(x => x.CityId == cityId).Where(x => x.WorkId == workId).ToList();
        }
    } 
}