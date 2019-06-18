using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    [Table("x_keahlian")]
    public class Keahlian
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long id { get; set; }


        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }


        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public long biodata_id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string skill_name { get; set; }

        [Range(1, 11)]
        public Nullable<long>skill_level_id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string notes { get; set; }
    }
}