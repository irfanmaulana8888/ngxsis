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
        }

    }
}
