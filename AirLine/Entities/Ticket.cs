namespace AirLine.Domain.Entities;

public class Ticket : IEntity
{
    public int TicketId { get; set; }

    public User User { get; set; }
    public Guid UserId { get; set; }

    public string From { get; set; }
    public string Destinations { get; set; }
    public int Price { get; set; }
    public bool HasDelay { get; set; } = false;
    public bool IsCanceled { get; set; }
    public DateTime BuyTicket { get; set; }
    public DateTime FlightDate { get; set; }
    public DateTime LandTime { get; set; }

    public TicketType TicketTypes { get; set; }
    public AirLinesCompany AirLinesCompany { get; set; }
}
