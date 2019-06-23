using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

namespace Xsis.Repo
{
    public class ProyekRepo
    {
        public static Boolean Createproyek(Riwayat_Proyek proyekmdl)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    proyekmdl.created_by = proyekmdl.created_by;
                    proyekmdl.created_on = DateTime.Now;
                    db.Riwayat_Proyek.Add(proyekmdl);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //public static List<Riwayat_Proyek> GetAll()
        //{
        //    List<Riwayat_Proyek> result = new List<Riwayat_Proyek>();
        //    using (var db = new DataContext())
        //    {

        //        result = (from t in db.Riwayat_Proyek
        //                  where t.is_delete == false
        //                  select t).ToList();
        //        return result;
        //    }
        //}

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

    }
}
