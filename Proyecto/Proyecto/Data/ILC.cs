namespace Proyecto.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ILC : DbContext
    {
        public ILC()
            : base("name=ILC")
        {
        }

        public virtual DbSet<EdgeSet> EdgeSets { get; set; }
        public virtual DbSet<GraphSet> GraphSets { get; set; }
        public virtual DbSet<NodeSet> NodeSets { get; set; }
        public virtual DbSet<RoleSet> RoleSets { get; set; }
        public virtual DbSet<UserSet> UserSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EdgeSet>()
                .HasMany(e => e.NodeSets)
                .WithMany(e => e.EdgeSets)
                .Map(m => m.ToTable("EdgeNode").MapLeftKey("Edge_Id").MapRightKey("Node_Id"));

            modelBuilder.Entity<GraphSet>()
                .HasMany(e => e.NodeSets)
                .WithRequired(e => e.GraphSet)
                .HasForeignKey(e => e.GraphId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleSet>()
                .HasMany(e => e.UserSets)
                .WithRequired(e => e.RoleSet)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserSet>()
                .Property(e => e.Gender)
                .IsUnicode(false);
        }
    }
}
