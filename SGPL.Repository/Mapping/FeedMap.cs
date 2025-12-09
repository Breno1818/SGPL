using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPL.Domain.Entities;

namespace SGPL.Repository.Mapping
{
    public class FeedMap : IEntityTypeConfiguration<Feed>
    {
        public void Configure(EntityTypeBuilder<Feed> builder)
        {
            builder.ToTable("Feeds");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.FeedType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.Quantity)
                .IsRequired();
        }
    }
}
