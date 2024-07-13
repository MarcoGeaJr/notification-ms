using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.EmailNotifiers;

public class EmailNotifierV2 : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
