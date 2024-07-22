using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ProjectLocationConfiguration : IEntityTypeConfiguration<ProjectLocation>
    {
        public void Configure(EntityTypeBuilder<ProjectLocation> builder)
        {
            builder
                .HasKey(pl => new { pl.ProjectId, pl.LocationId });
            builder
                .HasOne(pl => pl.Project)
                .WithMany(p => p.ProjectLocations)
                .HasForeignKey(pl => pl.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(pl => pl.Location)
                .WithMany(l => l.ProjectLocations)
                .HasForeignKey(pl => pl.LocationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
