using AirLine.Application.Common.Interfaces.SmsService;

namespace AirLine.Infrastructure.SmsProvider;

public class SmsAdapter : ISmsAdapter
{
    public async Task<int> SendAsync(string reciever, string text)
    {
        await Task.CompletedTask;
        return 0;
    }
}
