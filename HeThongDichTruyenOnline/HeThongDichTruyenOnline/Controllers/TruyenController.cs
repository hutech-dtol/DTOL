using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeThongDichTruyenOnline.Controllers
{
    public class TruyenController : Controller
    {
        // GET: Truyen
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TaoMoi()
        {
            return View();
        }
    }
}