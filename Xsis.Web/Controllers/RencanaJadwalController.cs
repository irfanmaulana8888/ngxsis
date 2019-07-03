using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;
using Xsis.ViewModel;

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

        public ActionResult Save(RencanaJadwalViewModel rj)
        {
            rj.created_by = Convert.ToInt64(Session["foo"]);
            if (RencanaJadwalRepo.CreateRJ(rj))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}