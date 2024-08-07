using EventProject.Domain.Entities;
using EventProject.Domain.Entities.Account;
using EventProject.Infrastructure.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EventProject.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Evaluation> Evaluations { get; set; } = null!;

        public DbSet<Location> Locations { get; set; } = null!;

        public DbSet<PrintingHouse> PrintingHouses { get; set; } = null!;

        public DbSet<PrintMaterials> PrintMaterials { get; set; } = null!;

        public DbSet<Project> Projects { get; set; } = null!;

        public DbSet<ProjectEvaluation> ProjectEvaluations { get; set; } = null!;

        public DbSet<ProjectLocation> ProjectsLocations { get; set; } = null!;

        public DbSet<ProjectMaterials> ProjectMaterials { get; set; } = null!;

        public DbSet<ProjectStatus> ProjectStatus { get; set; } = null!;

        public DbSet<ProjectType> ProjectTypes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Customer>(new CustomerConfiguration());
            builder.ApplyConfiguration<ProjectMaterials>(new ProjectMaterialsConfiguration());
            builder.ApplyConfiguration<Project>(new ProjectConfiguration());
            builder.ApplyConfiguration<ProjectEvaluation>(new ProjectEvaluationConfiguration());
            builder.ApplyConfiguration<ProjectLocation>(new ProjectLocationConfiguration());
            builder.ApplyConfiguration<ApplicationUser>(new ApplicationUserConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
