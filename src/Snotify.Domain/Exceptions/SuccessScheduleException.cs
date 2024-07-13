using Snotify.Domain.Entity;

namespace Snotify.Domain.Exceptions;

public class SuccessScheduleException : InvalidOperationException
{
	public static void ThrowIfSent(Schedule schedule)
	{
		if (schedule.Status != ScheduleStatus.SUCCESS) return;

		throw new SuccessScheduleException();
	}
}
