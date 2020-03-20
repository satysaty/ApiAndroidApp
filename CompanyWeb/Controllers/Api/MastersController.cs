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
    public class MastersController : ApiController
    {
        DataContext Data = new DataContext();

        [Route("api/masters/{city}")]
        public IEnumerable<Master> Get(int city)
        {
            return Data.Masters.Where(x => x.CityId == city).ToList();
        }

        [Route("api/masters/{work}/{city}")]
        public IEnumerable<Master> Get(int work, int city)
        {
            return Data.Works.Where(x => x.Id == work).SelectMany(x=>x.Masters);
        }
    }
}