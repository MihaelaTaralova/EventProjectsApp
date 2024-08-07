using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectEvaluationConfiguration : IEntityTypeConfiguration<ProjectEvaluation>
    {
        public void Configure(EntityTypeBuilder<ProjectEvaluation> builder)
        {
          builder
                .HasKey(pd => new { pd.ProjectId, pd.UserId, pd.EvaluationId });
         
            builder
                .HasOne(pe => pe.Project)
                .WithMany()
                .HasForeignKey(pe => pe.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(pe => pe.User)
                .WithMany(au => au.ProjectsEvaluations)
                .HasForeignKey(pe => pe.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(pe => pe.Evaluation)
                .WithMany()
                .HasForeignKey(pe => pe.EvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
