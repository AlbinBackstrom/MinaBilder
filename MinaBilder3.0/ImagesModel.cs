namespace MinaBilder3._0
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ImagesModel : DbContext
    {
        public ImagesModel()
            : base("name=ImagesModel")
        {
        }

        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
