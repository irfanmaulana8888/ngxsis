using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class BiodataRepo
    {
        public static List<Biodata> GetAll()
        {
            List<Biodata> result = new List<Biodata>();
            using (DataContext db = new DataContext())
            {
                result = db.Biodata.ToList();
            }
            return result;
        }
    }
}
