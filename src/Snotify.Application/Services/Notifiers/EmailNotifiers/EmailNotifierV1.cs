using Snotify.Domain.ValueObjects;

namespace Snotify.Application.Services.Notifiers.EmailNotifiers;

public class EmailNotifierV1 : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
