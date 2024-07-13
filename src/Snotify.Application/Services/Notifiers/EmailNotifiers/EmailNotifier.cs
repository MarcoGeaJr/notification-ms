using Snotify.Application.Services.Notifiers;
using Snotify.Domain.Entity;

namespace Snotify.Application.Services.Notifiers.EmailNotifiers;

public class EmailNotificationSenderV1 : INotifier
{
    public Task SendAsync(Notification notification)
    {
        throw new NotImplementedException();
    }
}
