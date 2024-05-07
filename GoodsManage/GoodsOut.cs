namespace GoodsManage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsOut")]
    public partial class GoodsOut
    {
        [Key]
        public int OutID { get; set; }

        public int? GoodsID { get; set; }

        public DateTime? OutTime { get; set; }

        public double? Num { get; set; }

        public virtual GoodsInfo GoodsInfo { get; set; }
    }
}
