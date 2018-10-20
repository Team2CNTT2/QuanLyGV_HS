namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMON")]
    public partial class tblMON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMON()
        {
            tblKET_QUA = new HashSet<tblKET_QUA>();
        }

        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        public int? SoDVHT { get; set; }

        [StringLength(10)]
        public string HocKi { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKET_QUA> tblKET_QUA { get; set; }
    }
}
