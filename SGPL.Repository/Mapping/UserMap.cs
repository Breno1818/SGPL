using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPL.Domain.Entities;

namespace SGPL.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(prop => prop.Password)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(prop => prop.RegisterDate)
                .IsRequired();

            builder.Property(prop => prop.LoginDate)
                .IsRequired();

            builder.Property(prop => prop.IsActive)
                .IsRequired();
        }
    }
}
