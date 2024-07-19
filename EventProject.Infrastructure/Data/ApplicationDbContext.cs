using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EventProject.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Designer> Designers { get; set; }

        public DbSet<DesignerCategory> DesignersCategories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<PrintMaterials> PrintMaterials { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectManager> ProjectManagers { get; set; }

        public DbSet<ProjectStatus> ProjectStatus { get; set; }

        public DbSet<ProjectType> ProjectTypes { get; set; }
    }
}
