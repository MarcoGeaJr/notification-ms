namespace Snotify.Domain.ValueObjects;

public record Message(string Source, string Destination, string Body);
