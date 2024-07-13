using Snotify.Domain.SeedWork;

namespace Snotify.Domain.ValueObjects;

public class Channel(int id, string name)
    : Enumeration(id, name)
{
    public static Channel EMAIL = new(1, nameof(EMAIL));

    public static Channel SMS = new(2, nameof(SMS));

    public static Channel PUSH = new(3, nameof(PUSH));

    public static Channel WHATSAPP = new(4, nameof(WHATSAPP));

    public static Channel INAPP = new(5, nameof(INAPP));
}
