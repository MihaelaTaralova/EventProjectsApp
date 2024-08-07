
using EventProject.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventProject.Infrastructure.Data.EntityConfigurations
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                 .HasMany(p => p.Projects)
                 .WithOne(u => u.ProjectManager)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
