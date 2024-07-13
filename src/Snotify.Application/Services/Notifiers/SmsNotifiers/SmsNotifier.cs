using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.SmsNotifiers;

public class SmsNotifier : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
