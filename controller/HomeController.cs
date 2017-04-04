using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("Index");
        }
        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(string id, string X_nme, string Prop, string Mail, string M, string Add, string Location, string R, string cmd)
        {

            ServiceReference1.Service1Client c1 = new ServiceReference1.Service1Client();
            if (cmd == "Save")
            {
            c1.save(id, X_nme, Prop, Mail, M, Add, Location, R);
            }
            return null;
        }
        
    }
}
