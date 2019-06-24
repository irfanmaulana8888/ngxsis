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

        public ActionResult Tampil()
        {
            return Json(ProyekRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(ProyekRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteCfr(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult EditSimpan(Riwayat_Proyek proyek)
        {
            proyek.modified_by = Convert.ToInt64(Session["foo"]);
            if (ProyekRepo.Editproyek(proyek))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(int ID, Riwayat_Proyek proyekmdl)
        {
            proyekmdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (ProyekRepo.Deleteproyek(ID, proyekmdl)) //non static if ( KeahlianRepo.Deletekeahlian(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}