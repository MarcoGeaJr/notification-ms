using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.WhatsAppNotifiers;

public class WhatsAppNotifier : INotifier
{
	public Task SendAsync(Notification notification)
	{
		throw new NotImplementedException();
	}
}
