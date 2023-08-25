namespace AirLine.Infrastructure.Persistence.Configuration;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.UserId);

        builder.Property(u => u.FirstName)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(11)
             .IsRequired();

        builder.Property(u => u.Age)
              .IsRequired();

        builder.HasMany(x => x.Tickets)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}
