﻿namespace AirLine.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
