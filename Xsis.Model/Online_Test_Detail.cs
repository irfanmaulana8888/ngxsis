using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Xsis.Model
{
    [Table("x_online_test_detail")]
    public class Online_Test_Detail
    {
        // ID AUTO INCREAMENT PRIMARY KEY
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings = false)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column(TypeName = "Date")]
        public DateTime create_on { get; set; }
        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }
        public long delete_by { get; set; }
        [Column(TypeName = "Date")]
        public DateTime delete_on { get; set; }
        [Required(AllowEmptyStrings = false)]
        public Boolean is_delete { get; set; }
        public long online_test_id { get; set; }
        public long test_type_id { get; set; }
        public int test_order { get; set; }
    }
}