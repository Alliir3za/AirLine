using AirLine.Domain.Entities;
using MediatR;

namespace AirLine.Application.Users.Queries.GetUser;

public class GetUsersQuery : IRequest<User>
{
    public int UserId { get; set; }
}