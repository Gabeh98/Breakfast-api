using ErrorOr;

namespace BuberBreakfast.Services.Errors;
public static class Cases
{
    public static class Breakfast
    {
        public static Error NotFound => Error.NotFound(code: "Breakfast.NotFound", description: "Breakfast not found");
    }
}