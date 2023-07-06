using AirLine.Domain.Common.Interface;

namespace AirLine.Domain.Entities;

public class Ticket : IEntity
{
    public int TicketId { get; set; }
    public int Price { get; set; }
}
