using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignement2.Areas.ContactDetails.Controllers
{
    public class ManagementController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Index(Models.ContactDetails details)
        {
            return View(details);
        }        
    }
}
