using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class RencanaJadwalController : Controller
    {
        // GET: RencanaJadwal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Check()
        {
            return Json(RencanaJadwalRepo.GetCheck(), JsonRequestBehavior.AllowGet);
        }
    }
}