using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNuocHoa.Models;

namespace WebNuocHoa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        WebNuocHoaEntities db = new WebNuocHoaEntities();
        public ActionResult Index()
        {

            return PartialView(db.SPs.Where(n=>n.Moi==1).ToList());
        }
        
    }
}