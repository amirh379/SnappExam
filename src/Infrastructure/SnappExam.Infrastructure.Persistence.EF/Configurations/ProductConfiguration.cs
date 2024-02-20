using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnappExam.Core.Domain.Models.Products;
using SnappExam.Core.Domain.Models.Users;


namespace SnappExam.Infrastructure.Persistence.EF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasQueryFilter(s => s.IsActive && !s.IsDelete);
            builder.Property(a => a.Title).HasMaxLength(40);
            builder.Property(a => a.Price).HasColumnType("decimal(18,1)");
            builder.HasIndex(u => u.Title).IsUnique();

        }
    }
}
