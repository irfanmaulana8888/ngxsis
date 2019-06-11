using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_undangan")]
    public class Undangan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long undangan_id { get; set; }

        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime created_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }

        public long deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public long schedule_type_id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime invitation_date { get; set; }

        public long ro { get; set; }

        public long tro { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string other_ro_tro { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string location { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string status { get; set; }



    }
}