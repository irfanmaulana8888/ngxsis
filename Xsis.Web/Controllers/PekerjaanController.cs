using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class PekerjaanController : Controller
    {
        // GET: Pekerjaan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil()
        {
            return Json(PekerjaanRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Riwayat_Pekerjaan pekerjaan)
        {
            pekerjaan.created_by = Convert.ToInt64(Session["foo"]);
            if (PekerjaanRepo.Createpekerjaan(pekerjaan))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteCfr(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult Delete(int ID, Riwayat_Pekerjaan pekerjaanmdl)
        {
            pekerjaanmdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (PekerjaanRepo.Deletepekerjaan(ID, pekerjaanmdl)) //non static if ( KeahlianRepo.Deletekeahlian(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(PekerjaanRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditSimpan(Riwayat_Pekerjaan pekerjaan)
        {
            pekerjaan.modified_by = Convert.ToInt64(Session["foo"]);
            if (PekerjaanRepo.Editpekerjaan(pekerjaan))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}