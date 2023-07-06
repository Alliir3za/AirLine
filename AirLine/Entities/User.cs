using AirLine.Domain.Common.Interface;
using AirLine.Domain.Enum;

namespace AirLine.Domain.Entities;

public class User : IEntity
{
    public User() => UserId = Guid.NewGuid();

    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; }
}
