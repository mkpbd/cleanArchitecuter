using FirstDemo.Domain.Entities;
using FirstDemo.Persistence.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstDemo.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext 
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public ApplicationDbContext(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(_connectionString,
					(x) => x.MigrationsAssembly(_migrationAssembly));
			}

            base.OnConfiguring(optionsBuilder);
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Student>().HasData(StudentSeed.Students);

            base.OnModelCreating(modelBuilder);
        }

		public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}