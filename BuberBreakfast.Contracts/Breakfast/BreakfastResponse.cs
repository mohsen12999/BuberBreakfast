namespace BuberBreakfast.Contracts.Breakfast;

public record CreateBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StarDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet);