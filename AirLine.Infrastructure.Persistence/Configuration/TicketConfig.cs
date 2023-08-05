namespace AirLine.Infrastructure.Persistence.Configuration;

public class TicketConfig : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(x => x.TicketId);
        builder.Property(x => x.AirLinesCompany)
            .IsRequired();

        builder.Property(x => x.From)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.Destinations)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.FlightDate)
            .IsRequired();

        builder.Property(x => x.Price)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.UserId);

    }
}
