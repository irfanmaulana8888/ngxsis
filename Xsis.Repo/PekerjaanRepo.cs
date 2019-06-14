using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

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
    }
}
