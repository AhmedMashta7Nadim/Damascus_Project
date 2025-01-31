using Microsoft.EntityFrameworkCore;
using Model_Entity.Models;

namespace InfraStractur.Data
{
    public class ConnectionDataBase : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<UserCourse> usersCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB ; Initial Catalog= Damascus_db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

           

            modelBuilder.Entity<User>()
                .HasMany(x => x.courses)
                .WithMany(x => x.users)
                .UsingEntity<UserCourse>();

        }
    }
}
