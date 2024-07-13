using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.PushNotifiers;

public class PushNotifier : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
