using Snotify.Domain.ValueObjects;

namespace Snotify.Application.Services.Notifiers.SmsNotifiers;

public class SmsNotifier : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
