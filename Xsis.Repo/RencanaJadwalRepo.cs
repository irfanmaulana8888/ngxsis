using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class RencanaJadwalRepo
    {
        public static List<Biodata> GetCheck()
        {
            List<Biodata> result = new List<Biodata>();
            using (var db = new DataContext())
            {
                result = db.Biodata.ToList();
                return result;
            }
        }

    }
}
