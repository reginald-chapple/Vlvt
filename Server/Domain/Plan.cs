namespace Server.Domain;

public class Plan : AuditableEntity
{
    public long Id { get; set; }

    public string Label { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public ICollection<MealPlan> Meals { get; set; } = [];
}