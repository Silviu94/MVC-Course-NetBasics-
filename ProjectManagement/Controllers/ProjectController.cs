using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    
    public class ProjectController : Controller
    {
        public ActionResult Doanaction()
        {
            return Content("Hello world!!");


        }
        public int Search(int alpha)
        {
            return alpha;
        }
        public ActionResult HelloUser(string name )
        {
            string econdedName = Server.HtmlEncode(name);
            //return Content("Hello: "+name);
            return Content("Hello: ", econdedName);
        }


    }
    }