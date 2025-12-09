using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPL.Domain.Entities;

namespace SGPL.Repository.Mapping
{
    public class ProductionMap : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.ToTable("Productions");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Product)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.Quantity)
                .IsRequired();

            builder.HasOne(prop => prop.Feed)
                .WithMany()
                .IsRequired();
        }
    }
}
