using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using BCSVM.Common;
using BCSVM.IndustriesRepo;
using BCS2017.CommonRepository;
using BCS2017.Models;

namespace BCS2017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RegistrationVM models = new RegistrationVM();
            DataTable dt = new DataTable();
            dt = IndRepository.GetUserData(1);
            models.ddlCtegory = CommomMethods.ToSelectList(dt, "CategoryName", "CategoryID");
            
            return View(models);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}