using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class PenggunaRepo
    {
        public static List<Biodata> GetAll()
        {
            List<Biodata> result = new List<Biodata>();
            using (var db = new DataContext())
            {
                //result = db.Keahlian.ToList();

                result = (from t in db.Biodata
                          where t.is_delete == false
                          select t).ToList();
                //select new Keahlian { skill_name = t.skill_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Keahlian
                //          where item.is_delete == false
                //          select new Keahlian { item.skill_name }).ToList();
                return result;
            }
        }

        public static Biodata GetByID(string ID)
        {
            Biodata pengguna = new Biodata();
            using (DataContext db = new DataContext())
            {
                pengguna = db.Biodata.Where(d => d.fullname == ID).First();
                return pengguna;
            }
        }
    }
}
