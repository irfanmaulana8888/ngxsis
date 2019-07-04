using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    class Initializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Skill_Level> skill_level = new List<Skill_Level>();
            skill_level.Add(new Skill_Level { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false , name = "Novice", description = "Novice" });
            skill_level.Add(new Skill_Level { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Beginner", description = "Beginner" });
            skill_level.Add(new Skill_Level { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Professional", description = "Professional" });
            skill_level.Add(new Skill_Level { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Competent", description = "Competent" });
            skill_level.Add(new Skill_Level { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Expert", description = "Expert" });
            base.Seed(context);

            foreach (var item in skill_level)
            {
                context.Skill_Level.Add(item);
            }

            List<Biodata> biodata = new List<Biodata>();
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "irfan maulana", nick_name = "irfan", pob = "Jakarta", dob = DateTime.Now, gender=true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic ="Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123",email = "irfanmaulanaa8888@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1   });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "harsan febrian", nick_name = "harsa", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "harsan123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "latifa sudar", nick_name = "tifa", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "latifa123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "mawalid", nick_name = "walid", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "walid123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "putri hartono", nick_name = "putri", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "putri123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            base.Seed(context);

            foreach (var item in biodata)
            {
                context.Biodata.Add(item);
            }

            List<Role> role = new List<Role>();
            role.Add(new Role { code = "A1", name = "Admin", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            role.Add(new Role { code = "A2", name = "User", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            role.Add(new Role { code = "A3", name = "Manager", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            role.Add(new Role { code = "A4", name = "Hrd", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            role.Add(new Role { code = "A5", name = "Direktur", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            base.Seed(context);

            foreach (var item in role)
            {
                context.Role.Add(item);
            }

            List<Schedule_Type> schedule = new List<Schedule_Type>();
            schedule.Add(new Schedule_Type { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Interview", description = "Nanyain Orang" });
            schedule.Add(new Schedule_Type { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Test", description = "Nguji Orang" });
            schedule.Add(new Schedule_Type { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, name = "Bootcamp", description = "Ngajarin Orang" });
            base.Seed(context);

            foreach (var item in schedule)
            {
                context.Schedule_Type.Add(item);
            }
        }

    }
}
