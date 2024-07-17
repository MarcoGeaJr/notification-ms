using Grpc.Core;

namespace Snotify.API.Grpc;

public class NotificationScheduleService : NotificationSchedule.NotificationScheduleBase
{
	public override Task<NotificationStatusResponse> GetNotificationStatus(GetNotificationStatusRequest request, ServerCallContext context)
	{
		// try get from cache

		// try get from db

		// not found exception

		// save on cache

		// return

		return base.GetNotificationStatus(request, context);
	}
}
