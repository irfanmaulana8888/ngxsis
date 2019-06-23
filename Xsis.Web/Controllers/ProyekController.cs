using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class ProyekController : Controller
    {
        // GET: Proyek
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Riwayat_Proyek proyek)
        {
            proyek.created_by = Convert.ToInt64(Session["foo"]);
            if (ProyekRepo.Createproyek(proyek))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult Tampil()
        //{
        //    return Json(ProyekRepo.GetAll(), JsonRequestBehavior.AllowGet);
        //}
    }
}