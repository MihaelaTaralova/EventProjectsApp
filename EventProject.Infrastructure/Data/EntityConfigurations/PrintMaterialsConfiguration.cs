using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class PrintMaterialsConfiguration : IEntityTypeConfiguration<PrintMaterials>
    {
        public void Configure(EntityTypeBuilder<PrintMaterials> builder)
        {
            builder
                .HasOne(p => p.Project)
                .WithMany()
                .HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
