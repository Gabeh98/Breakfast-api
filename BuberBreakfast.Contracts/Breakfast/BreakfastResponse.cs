namespace BuberBreakfast.Contracts;

public record BreakFastResponse(
    Guid id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);