using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectDesignerConfiguration : IEntityTypeConfiguration<ProjectDesigner>
    {
        public void Configure(EntityTypeBuilder<ProjectDesigner> builder)
        {
          builder
                .HasKey(pd => new { pd.ProjectId, pd.DesignerId });
            builder
                 .HasOne(pd => pd.Project)
                .WithMany(p => p.ProjectDesigners)
                .HasForeignKey(pd => pd.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                 .HasOne(pd => pd.Designer)
                .WithMany(d => d.ProjectDesigners)
                .HasForeignKey(pd => pd.DesignerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
