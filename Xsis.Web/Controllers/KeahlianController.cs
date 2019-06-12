using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class KeahlianController : Controller
    {
        // GET: Keahlian
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(KeahlianRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Keahlian keahlian)
        {
            keahlian.created_by = Convert.ToInt64(Session["foo"]);
            if (KeahlianRepo.Createkeahlian(keahlian))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }
    }
}