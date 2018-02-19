using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using BCSVM.Common;
using BCSVM.IndustriesRepo;

namespace BCS2017.Controllers
{
    public class IndustriesController : Controller
    {
        // GET: Industries
        public ActionResult Registration()
        {
            DataTable dt = new DataTable();
            //dt = IndRepository.GetUserData("bharat", "Deepak");
            return View();
        }
    }
}