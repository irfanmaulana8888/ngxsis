﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

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


        public static long GetLast()
        {
            
            List<Rencana_Jadwal> result = new List<Rencana_Jadwal>();
            using (var db = new DataContext())
            {

                result = (from t in db.Rencana_Jadwal
                          select t).ToList();

                long length = result.Count();

                return length;
            }
        }

        public static Boolean CreateRJ(RencanaJadwalViewModel RJmdl)
        {
            try
            {
                Rencana_Jadwal rencana = new Rencana_Jadwal();
                using (DataContext db = new DataContext())
                {
                    var d = true;
                    if (RJmdl.is_automatic_mail == null)
                    {
                        d = false;
                    }

                    rencana.created_by = RJmdl.created_by;
                    rencana.created_on = DateTime.Now;
                    rencana.schedule_code = RJmdl.schedule_code;
                    rencana.schedule_date = RJmdl.schedule_date;
                    rencana.time = RJmdl.time;
                    rencana.ro = RJmdl.ro;
                    rencana.tro = RJmdl.tro;
                    rencana.schedule_type_id = RJmdl.schedule_type_id;
                    rencana.location = RJmdl.location;
                    rencana.other_ro_tro = RJmdl.other_ro_tro;
                    rencana.notes = RJmdl.notes;
                    rencana.is_automatic_mail = d;
                    rencana.sent_date = RJmdl.sent_date;
                    rencana.status = RJmdl.status;
                    db.Rencana_Jadwal.Add(rencana);
                    db.SaveChanges();

                    Rencana_Jadwal_Detail rencanadetail = new Rencana_Jadwal_Detail();
                    var a = RJmdl.biodata_id;
                    string[] bio = a.Split(',');
                    
                    foreach (var item in bio)
                    {
                    rencanadetail.created_by = RJmdl.created_by;
                    rencanadetail.created_on = DateTime.Now;
                    rencanadetail.rencana_jadwal_id = RJmdl.id_auto;
                    rencanadetail.biodata_id = Convert.ToInt16(item);
                    db.Rencana_Jadwal_Detail.Add(rencanadetail);
                    db.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static List<Rencana_Jadwal> GetData(DateTime Dari , DateTime Sampai)
        {
            List<Rencana_Jadwal> rencana = new List<Rencana_Jadwal>();
            using (DataContext db = new DataContext())
            {
                rencana = db.Rencana_Jadwal.Where(d => d.schedule_date >= Dari && d.schedule_date <= Sampai).ToList();
                return rencana;
            }
        }
    }
}
