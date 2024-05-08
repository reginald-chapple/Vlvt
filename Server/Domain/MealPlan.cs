namespace Server.Domain;

public class MealPlan : Entity
{
    public DateOnly Date { get; set; }

    public MealCategory Category { get; set; }

    public long MealId { get; set; }
    public virtual Meal? Meal { get; set; }

    public long PlanId { get; set; }
    public virtual Plan? Plan { get; set; }
}