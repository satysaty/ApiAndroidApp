using CompanyWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyWeb.Controllers
{
    public class RepairsController : ApiController
    {
        DataContext Data = new DataContext();
      
        [Route("api/repairs/")]
        public IHttpActionResult Post(Repair repair)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var options = repair.Options;

                var options_new = new List<Option>();

                foreach (var option in repair.Options)
                {
                    var option_db = Data.Options.Where(x=> x.Id == option.Id).FirstOrDefault();
                    
                    if (option_db != null)
                        options_new.Add(option_db); 
                }

                var work_db = Data.Works.Where(x => x.Id == repair.Work.Id).FirstOrDefault();

                if (work_db != null)
                    repair.Work = work_db;

                repair.Options = options_new;
                Data.Repairs.Add(repair);
                Data.SaveChanges();
                return Ok(repair);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }


    } 
}