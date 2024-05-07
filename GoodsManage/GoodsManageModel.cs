namespace GoodsManage
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GoodsManageModel : DbContext
    {
        public GoodsManageModel()
            : base("name=GoodsManage")
        {
        }

        public virtual DbSet<GoodsIn> GoodsIns { get; set; }
        public virtual DbSet<GoodsInfo> GoodsInfoes { get; set; }
        public virtual DbSet<GoodsOut> GoodsOuts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
