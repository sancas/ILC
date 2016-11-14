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

        public virtual DbSet<Edge> Edges { get; set; }
        public virtual DbSet<Graph> Graphs { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TravelProblem> TravelProblems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Graph>()
                .HasMany(e => e.Edges)
                .WithRequired(e => e.Graph)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Graph>()
                .HasMany(e => e.Nodes)
                .WithRequired(e => e.Graph)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TravelProblem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);
        }
    }
}
