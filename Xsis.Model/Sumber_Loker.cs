using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_sumber_loker")]
    public class Sumber_Loker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long sumber_loker_id { get; set; }

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

        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string vacancy_source { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string candidate_type { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string event_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string career_center_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string referrer_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string referrer_phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string referrer_email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string other_source { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string last_income { get; set; }

        [Column(TypeName = "Date")]
        public DateTime apply_date { get; set; }

    }
}
