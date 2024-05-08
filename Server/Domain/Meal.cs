using System.ComponentModel;

namespace Server.Domain;

public class Meal : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public MealCategory Category { get; set; }

    public ICollection<MealRecipe> Recipes { get; set; } = [];

    public ICollection<MealPlan> Plans { get; set; } = [];
}

public enum MealCategory
{
    [Description("Breakfast")]
    Breakfast,
    [Description("Lunch")]
    Lunch,
    [Description("Dinner")]
    Dinner,
    [Description("Anytime")]
    Anytime,
}
