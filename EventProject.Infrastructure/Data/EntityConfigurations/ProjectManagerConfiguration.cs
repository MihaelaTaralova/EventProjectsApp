using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectManagerConfiguration : IEntityTypeConfiguration<ProjectManager>
    {
        public void Configure(EntityTypeBuilder<ProjectManager> builder)
        {
            builder
                .HasMany(p => p.Projects)
                .WithOne(p => p.ProjectManager)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
