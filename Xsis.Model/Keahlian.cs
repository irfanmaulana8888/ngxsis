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

        public long keahlian_id { get; set; }


        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long modified_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime modified_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long deleted_by { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime deleted_on { get; set; }


        public Boolean is_delete { get; set; }

        public long biodata_id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = true)]
        public string skill_name { get; set; }

        [Range(1, 11)]
        [Required(AllowEmptyStrings = true)]
        public long skill_level_id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(1000)]
        [Required(AllowEmptyStrings = true)]
        public string notes { get; set; }
    }
}