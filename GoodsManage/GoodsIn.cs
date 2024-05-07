namespace GoodsManage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsIn")]
    public partial class GoodsIn
    {
        [Key]
        public int InID { get; set; }

        public int? GoodsID { get; set; }

        public DateTime? InTime { get; set; }

        public int? Num { get; set; }

        public virtual GoodsInfo GoodsInfo { get; set; }
    }
}
