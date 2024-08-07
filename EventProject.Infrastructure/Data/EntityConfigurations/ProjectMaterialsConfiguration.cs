using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectMaterialsConfiguration : IEntityTypeConfiguration<ProjectMaterials>
    {
        public void Configure(EntityTypeBuilder<ProjectMaterials> builder)
        {
            builder
                .HasKey(pd => new { pd.ProjectId, pd.MaterialId, pd.PrintingHouseId });
            builder
                .HasOne(p => p.Project)
                .WithMany(p => p.ProjectMaterials)
                .HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
