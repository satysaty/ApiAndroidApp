using CompanyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Controllers
{
    public class RepairController : Controller
    {
        DataContext Data = new DataContext();
        // GET: Repair
        public ActionResult Index()
        {
            ViewBag.Repairs = Data.Repairs.Include(p => p.Options).Include(p => p.Work);
            return View();
        }
    }
}