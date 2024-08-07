using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            // ProjectStatus relationship
            builder
                .HasOne(p => p.ProjectStatus)
                .WithMany()
                .HasForeignKey(p => p.ProjectStatusId)
                .OnDelete(DeleteBehavior.NoAction);

            // ProjectType relationship
            builder
                .HasOne(p => p.ProjectType)
                .WithMany()
                .HasForeignKey(p => p.ProjectTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.GraphicDesignerEvaluation)
                .WithMany()
                .HasForeignKey(p => p.GraphicDesignerEvaluationID)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.ScenicDesignerEvaluation)
                .WithMany()
                .HasForeignKey(p => p.ScenicDesignerEvaluationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.ProjectManager)
                .WithMany()
                .HasForeignKey(u => u.ProjectManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
