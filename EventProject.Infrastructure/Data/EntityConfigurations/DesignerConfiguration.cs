using EventProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class DesignerConfiguration : IEntityTypeConfiguration<Designer>
    {
        public void Configure(EntityTypeBuilder<Designer> builder)
        {
            builder
                 .HasOne(p => p.DesignerCategory)
                 .WithMany()
                 .HasForeignKey(p => p.DesignerCategoryId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
