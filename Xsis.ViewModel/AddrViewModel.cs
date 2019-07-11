using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.ViewModel
{
    public class AddrViewModel
    {
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

        public Boolean is_locked { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string email { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string abuid { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string abpwd { get; set; }

        public string role_id { get; set; }
    }
}
