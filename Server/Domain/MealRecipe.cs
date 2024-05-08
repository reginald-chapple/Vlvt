namespace Server.Domain;

public class MealRecipe : Entity
{
    public long MealId { get; set; }
    public virtual Meal? Meal { get; set; }

    public long RecipeId { get; set; }
    public virtual Recipe? Recipe { get; set; }
}