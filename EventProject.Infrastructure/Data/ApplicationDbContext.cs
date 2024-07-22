using EventProject.Domain.Entities;
using EventProject.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;


namespace EventProject.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Designer> Designers { get; set; } = null!;

        public DbSet<DesignerCategory> DesignersCategories { get; set; } = null!;

        public DbSet<Location> Locations { get; set; } = null!;

        public DbSet<PrintMaterials> PrintMaterials { get; set; } = null!;

        public DbSet<Project> Projects { get; set; } = null!;

        public DbSet<ProjectDesigner> ProjectsDesigners { get; set; } = null!;

        public DbSet<ProjectLocation> ProjectsLocations { get; set; } = null!;

        public DbSet<ProjectManager> ProjectManagers { get; set; } = null!;

        public DbSet<ProjectStatus> ProjectStatus { get; set; } = null!;

        public DbSet<ProjectType> ProjectTypes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Customer>(new CustomerConfiguration());
            builder.ApplyConfiguration<Designer>(new DesignerConfiguration());
            builder.ApplyConfiguration<PrintMaterials>(new PrintMaterialsConfiguration());
            builder.ApplyConfiguration<Project>(new ProjectConfiguration());
            builder.ApplyConfiguration<ProjectDesigner>(new ProjectDesignerConfiguration());
            builder.ApplyConfiguration<ProjectLocation>(new ProjectLocationConfiguration());
            builder.ApplyConfiguration<ProjectManager>(new  ProjectManagerConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
