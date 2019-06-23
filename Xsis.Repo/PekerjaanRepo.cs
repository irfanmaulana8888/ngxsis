using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

namespace Xsis.Repo
{
    public class PekerjaanRepo
    {
        public static List<Riwayat_Pekerjaan> GetAll()
        {
            List<Riwayat_Pekerjaan> result = new List<Riwayat_Pekerjaan>();
            using (var db = new DataContext())
            {
                //result = db.Keahlian.ToList();

                result = (from t in db.Riwayat_Pekerjaan
                          where t.is_delete == false
                          select t).ToList();
                //select new Keahlian { skill_name = t.skill_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Keahlian
                //          where item.is_delete == false
                //          select new Keahlian { item.skill_name }).ToList();
                return result;
            }
        }

        //public static List<PekerjaanViewModel> GetAll()
        //{
        //    List<PekerjaanViewModel> result = new List<PekerjaanViewModel>();
        //    using (var db = new DataContext())
        //    {
        //        result = (from item in db.Riwayat_Pekerjaan
        //                  join Riwayat_Proyek in db.Riwayat_Proyek on item.id equals Riwayat_Proyek.riwayat_pekerjaan_id
        //                  where item.is_delete == false && Riwayat_Proyek.is_delete == false
        //                  select new PekerjaanViewModel
        //                  {
        //                      id = item.id,
        //                      company_name = item.company_name,
        //                      join_year = item.join_year,
        //                      join_month = item.join_month,
        //                      resign_year = item.resign_year,
        //                      resign_month = item.resign_month,
        //                      notes = item.notes,
        //                      //riwayat proyek
        //                      project_name = Riwayat_Proyek.project_name,
        //                      id_proyek = Riwayat_Proyek.id,
        //                      start_year = Riwayat_Proyek.start_year,
        //                      start_month = Riwayat_Proyek.start_month,
        //                      project_duration = Riwayat_Proyek.project_duration,
        //                      time_period_id = Riwayat_Proyek.time_period_id,
        //                      client = Riwayat_Proyek.client,
        //                      project_position = Riwayat_Proyek.project_position,
        //                      description = Riwayat_Proyek.description
        //                  }
        //                  ).ToList();
        //    }
        //    return result;
        //}

        public static Boolean Createpekerjaan(Riwayat_Pekerjaan pekerjaanmdl)
        {
            try
            {
                //Riwayat_Pekerjaan pekerjaan = new Riwayat_Pekerjaan();
                using (DataContext db = new DataContext())
                {
                    //pekerjaan.biodata_id = 1;
                    //pekerjaan.created_by = keahlianmdl.created_by;
                    //pekerjaan.created_on = DateTime.Now.Date;
                    //pekerjaan.skill_name = keahlianmdl.skill_name;
                    //pekerjaan.skill_level_id = keahlianmdl.skill_level_id;
                    //pekerjaan.notes = keahlianmdl.notes;
                    pekerjaanmdl.biodata_id = 1;
                    pekerjaanmdl.created_by = pekerjaanmdl.created_by;
                    pekerjaanmdl.created_on = DateTime.Now;
                    db.Riwayat_Pekerjaan.Add(pekerjaanmdl);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Boolean Deletepekerjaan(int ID, Riwayat_Pekerjaan pekerjaanmdl)
        {
            try
            {

                Riwayat_Pekerjaan dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Riwayat_Pekerjaan.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = pekerjaanmdl.deleted_by;
                    dep.deleted_on = DateTime.Now;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Riwayat_Pekerjaan GetByID(int ID)
        {
            Riwayat_Pekerjaan pekerjaan = new Riwayat_Pekerjaan();
            using (DataContext db = new DataContext())
            {
                pekerjaan = db.Riwayat_Pekerjaan.Where(d => d.id == ID).First();
                return pekerjaan;
            }
        }

        public static Boolean Editpekerjaan(Riwayat_Pekerjaan pekerjaan)
        {
            try
            {
                Riwayat_Pekerjaan dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Riwayat_Pekerjaan.Where(d => d.id == pekerjaan.id).First();
                    dep.modified_by = pekerjaan.modified_by;
                    dep.modified_on = DateTime.Now;
                    dep.company_name = pekerjaan.company_name;
                    dep.city = pekerjaan.city;
                    dep.country = pekerjaan.country;
                    dep.join_month = pekerjaan.join_month;
                    dep.join_year = pekerjaan.join_year;
                    dep.resign_month = pekerjaan.resign_month;
                    dep.resign_year = pekerjaan.resign_year;
                    dep.last_position = pekerjaan.last_position;
                    dep.income = pekerjaan.income;
                    dep.is_it_related = pekerjaan.is_it_related;
                    dep.about_job = pekerjaan.about_job;
                    dep.exit_reason = pekerjaan.exit_reason;
                    dep.notes = pekerjaan.notes;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
