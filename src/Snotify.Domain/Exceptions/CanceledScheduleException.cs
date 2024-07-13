using Snotify.Domain.Entity;

namespace Snotify.Domain.Exceptions;

public class CanceledScheduleException : InvalidOperationException
{
	public static void ThrowIfCanceled(Schedule schedule)
	{
		if (schedule.Status != ScheduleStatus.CANCELED) return;

		throw new CanceledScheduleException();
	}
}
