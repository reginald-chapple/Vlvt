namespace Server.Domain;

public class CookbookRecipe : Entity
{
    public long CookbookId { get; set; }
    public virtual Cookbook? Cookbook { get; set; }

    public long RecipeId { get; set; }
    public virtual Recipe? Recipe { get; set; }
}