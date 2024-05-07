namespace GoodsManage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsInfo")]
    public partial class GoodsInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsInfo()
        {
            GoodsIns = new HashSet<GoodsIn>();
            GoodsOuts = new HashSet<GoodsOut>();
        }

        [Key]
        public int GoodsID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public double? Num { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsIn> GoodsIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsOut> GoodsOuts { get; set; }
    }
}
