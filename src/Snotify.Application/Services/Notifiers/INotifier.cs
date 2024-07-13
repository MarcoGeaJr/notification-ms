using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers;

public interface INotifier
{
	Task SendAsync(Notification notification);
}
