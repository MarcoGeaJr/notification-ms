using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.InAppNotifiers;

public class InAppNotifier : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}