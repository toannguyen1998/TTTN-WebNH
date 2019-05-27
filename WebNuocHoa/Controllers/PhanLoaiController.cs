using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNuocHoa.Models;

namespace WebNuocHoa.Controllers
{
    public class PhanLoaiController : Controller
    {
        WebNuocHoaEntities db = new WebNuocHoaEntities();
        // GET: PhanLoai
        public ActionResult PhanLoaiPartial()
        {

            return PartialView(db.NhanHieux.ToList());
        }
    }
}