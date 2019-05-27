using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNuocHoa.Models;

namespace WebNuocHoa.Controllers
{
    public class NuocHoaController : Controller
    {
        // GET: /SanPhamPartial/
        WebNuocHoaEntities db = new WebNuocHoaEntities();
        public PartialViewResult SanPhamPartial()
        {
            var listSanPham = db.SPs.Take(3).ToList();
            return PartialView(listSanPham);
        }
        //public ViewResult XemChiTiet(int MaSP)
        //{
          //   nuochoa 
        //}
    }
}