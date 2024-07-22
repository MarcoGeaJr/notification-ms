using Snotify.Domain.Exceptions;
using Snotify.Domain.ValueObjects;

namespace Snotify.Domain.Entity;

public class Schedule(Notification notification, ScheduleStatus status, DateTime expiresAt)
{
	public Guid Id { get; }
	public Notification Notification { get; init; } = notification;
	public DateTime ExpiresAt { get; init; } = expiresAt;
	public ScheduleStatus Status { get; private set; } = status;

	public DateTime? SentIn { get; private set; }
	public DateTime? CanceledAt { get; private set; }

	public DateTime? LastAttempt { get; private set; }
	public int RetryCount { get; private set; } = 0;
	public string ErrorReason { get; private set; } = string.Empty;

	public void Send(DateTime timestamp)
	{
		CanceledScheduleException.ThrowIfCanceled(this);

		if (SentIn.HasValue) return;

		SentIn = timestamp;
		Status = ScheduleStatus.SUCCESS;
	}

	public void Cancel(DateTime timestamp)
	{
		SuccessScheduleException.ThrowIfSent(this);

		if (CanceledAt.HasValue) return;

		CanceledAt = timestamp;
		Status = ScheduleStatus.CANCELED;
	}

	public void Expire(DateTime timestamp)
	{
		if (Status is ScheduleStatus.SUCCESS or ScheduleStatus.CANCELED) return;

		if (timestamp < ExpiresAt) return;

		Status = ScheduleStatus.EXPIRED;
	}

	public void FailedAttemp(DateTime timestamp, string reason)
	{
		SuccessScheduleException.ThrowIfSent(this);
		CanceledScheduleException.ThrowIfCanceled(this);

		LastAttempt = timestamp;
		ErrorReason = reason;
		RetryCount++;
	}
}
