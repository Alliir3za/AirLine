namespace AirLine.Application.Common.Interfaces.SmsService;

public interface ISmsAdapter
{
    Task<int> SendAsync(string reciever, string text);
}
