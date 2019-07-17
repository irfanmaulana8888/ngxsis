using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                    rencana.schedule_code = ("JDW000000000" + RJmdl.id_auto );
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

                    int[] bio22 = Array.ConvertAll(bio, Element => int.Parse(Element));
                    
                    foreach (var item in bio)
                    {
                    rencanadetail.created_by = RJmdl.created_by;
                    rencanadetail.created_on = DateTime.Now;
                    rencanadetail.rencana_jadwal_id = RJmdl.id_auto;
                    rencanadetail.biodata_id = Convert.ToInt16(item);
                    db.Rencana_Jadwal_Detail.Add(rencanadetail);
                    db.SaveChanges();
                    }

                    if (RJmdl.is_automatic_mail == null)
                    {
                        using (DataContext dbbio = new DataContext())
                        {
                            foreach (var ambl in bio22)
                            {
                                List<Biodata> biodata = new List<Biodata>();
                                biodata = dbbio.Biodata.Where(dbio => dbio.id == ambl && dbio.is_delete == false).ToList();                                
                                foreach ( var kirime in biodata)
                                {
                                    var z = kirime.email;

                                        MailMessage mail = new MailMessage();

                                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                        mail.From = new MailAddress("academyxsis@gmail.com");
                                        mail.To.Add(z);
                                        mail.Subject = "Undangan PT. Xsis Mitra Utama";
                                        mail.IsBodyHtml = true;

                                        string date = RJmdl.schedule_date.ToString();

                                        string htmlStr =
                                            "<tr>" +
                                            "Helo " + kirime.fullname + " , " +
                                            "</tr>" +
                                            "<tr>" +
                                            "Terima kasih atas antusias anda untuk bergabung dengan kami." +
                                            "</tr>" +
                                            "<tr>" +
                                            "HRD PT. Xsis Mitra Utama mengundang anda untuk hadir pada :" +
                                            "</tr>" +
                                            "<tr>" +
                                            "Tanggal : " + date.Substring(0, 10) + "" +
                                            "</tr>" +
                                            "<tr>" +
                                            "Jam : " + RJmdl.time + "" +
                                            "</tr>" +
                                            "<tr>" +
                                            "Dimohon Hadir tepat waktu dengan mengenakan pakaian rapih dan bersepatu" +
                                            "</tr>";
                                        mail.Body = htmlStr;
                                        SmtpServer.Port = 587;
                                        SmtpServer.Credentials = new System.Net.NetworkCredential("academyxsis@gmail.com", "Irfan2@@");
                                        SmtpServer.EnableSsl = true;

                                        SmtpServer.Send(mail);

                                }
                            }
                        }
                       
                    }

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //public static List<Rencana_Jadwal> GetData(DateTime Dari , DateTime Sampai)
        //{
        //    List<Rencana_Jadwal> rencana = new List<Rencana_Jadwal>();
        //    using (DataContext db = new DataContext())
        //    {
        //        rencana = db.Rencana_Jadwal.Where(d => d.schedule_date >= Dari && d.schedule_date <= Sampai).ToList();
        //        return rencana;
        //    }
        //}

        public static List<RencanaJadwalViewModel> GetData(DateTime Dari, DateTime Sampai, string SortType)
        {
            List<RencanaJadwalViewModel> rencana = new List<RencanaJadwalViewModel>();
            using (DataContext db = new DataContext())
            {
                if (SortType == "1")
                {
                    rencana = (from item in db.Rencana_Jadwal
                               join Schedule_Type in db.Schedule_Type on item.schedule_type_id equals Schedule_Type.id
                               orderby item.id descending
                               where item.is_delete == false && item.schedule_date >= Dari && item.schedule_date <= Sampai
                               select new RencanaJadwalViewModel
                               {
                                   id = item.id,
                                   schedule_code = item.schedule_code,
                                   schedule_date = item.schedule_date,
                                   time = item.time,
                                   ro = item.ro,
                                   tro = item.tro,
                                   location = item.location,
                                   is_automatic_mail = item.is_automatic_mail,
                                   name_schedule = Schedule_Type.name
                               }
                              ).ToList();

                    return rencana;
                }else
                {
                    rencana = (from item in db.Rencana_Jadwal
                               join Schedule_Type in db.Schedule_Type on item.schedule_type_id equals Schedule_Type.id
                               orderby item.id ascending
                               where item.is_delete == false && item.schedule_date >= Dari && item.schedule_date <= Sampai
                               select new RencanaJadwalViewModel
                               {
                                   id = item.id,
                                   schedule_code = item.schedule_code,
                                   schedule_date = item.schedule_date,
                                   time = item.time,
                                   ro = item.ro,
                                   tro = item.tro,
                                   location = item.location,
                                   is_automatic_mail = item.is_automatic_mail,
                                   name_schedule = Schedule_Type.name
                               }
                              ).ToList();

                    return rencana;
                }
            }
        }

        public static List<Schedule_Type> GetSelect()
        {
            List<Schedule_Type> result = new List<Schedule_Type>();
            using (var db = new DataContext())
            {
                //result = (from item in db.Schedule_Type where item.is_delete == false
                //          select new Schedule_Type {
                //              id = item.id,
                //              name = item.name

                //}).ToList();
                result = db.Schedule_Type.Where(d =>  d.is_delete == false).ToList();
                return result;
            }
        }

        public static Rencana_Jadwal GetByID(int ID)
        {
            Rencana_Jadwal rencana = new Rencana_Jadwal();
            using (DataContext db = new DataContext())
            {
                rencana = db.Rencana_Jadwal.Where(d => d.id == ID).First();
                return rencana;
            }
        }

        public static List<Rencana_Jadwal_Detail> GetByID2(int ID)
        {
            List<Rencana_Jadwal_Detail> rencana2 = new List<Rencana_Jadwal_Detail>();
            using (DataContext db = new DataContext())
            {
                rencana2 = db.Rencana_Jadwal_Detail.Where(d => d.rencana_jadwal_id == ID && d.is_delete == false).ToList();
                return rencana2;
            }
        }

        public static Boolean Editrencana(RencanaJadwalViewModel editrj)
        {
            try
            {
                Rencana_Jadwal dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Rencana_Jadwal.Where(d => d.id == editrj.id).First();
                    dep.modified_by = editrj.modified_by;
                    dep.modified_on = DateTime.Now;
                    dep.schedule_date = editrj.schedule_date;
                    dep.time = editrj.time;
                    dep.ro = editrj.ro;
                    dep.tro = editrj.tro;
                    dep.schedule_type_id = editrj.schedule_type_id;
                    dep.location = editrj.location;
                    dep.notes = editrj.notes;
                    dep.is_automatic_mail = editrj.is_automatic_mail;
                    dep.sent_date = editrj.sent_date;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    //Rencana_Jadwal_Detail rens;
                    List<Rencana_Jadwal_Detail> hpsrencana2 = new List<Rencana_Jadwal_Detail>();
                    hpsrencana2 = db.Rencana_Jadwal_Detail.Where(d => d.rencana_jadwal_id == editrj.id && d.is_delete == false).ToList();
                    foreach(var ren in hpsrencana2)
                    {
                        //rens = db.Rencana_Jadwal_Detail.Where(d => d.rencana_jadwal_id == ren.rencana_jadwal_id).First();
                        ren.modified_by = editrj.modified_by;
                        ren.modified_on = DateTime.Now;
                        ren.deleted_by = editrj.deleted_by;
                        ren.deleted_on = DateTime.Now;
                        ren.is_delete = true;
                        db.Entry(ren).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    Rencana_Jadwal_Detail rencanadetail = new Rencana_Jadwal_Detail();

                    var a = editrj.biodata_id;
                    string[] bio = a.Split(',');

                    foreach (var item in bio)
                    {
                        rencanadetail.created_by = editrj.created_by;
                        rencanadetail.created_on = DateTime.Now;
                        rencanadetail.rencana_jadwal_id = editrj.id;
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

        public static Boolean Deleterencana(int ID, Rencana_Jadwal RJmdl)
        {
            try
            {

                Rencana_Jadwal dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Rencana_Jadwal.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = RJmdl.deleted_by;
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

    }
}
