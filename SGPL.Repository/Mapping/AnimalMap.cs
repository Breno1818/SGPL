using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPL.Domain.Entities;


namespace SGPL.Repository.Mapping
{
    public class AnimalMap : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animals");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.Age)
                .IsRequired();

            builder.Property(prop => prop.Producer)
                .IsRequired();

            builder.HasOne(prop => prop.Production)
                .WithMany()
                .IsRequired();
        }
    }
}
