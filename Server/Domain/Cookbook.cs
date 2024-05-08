namespace Server.Domain;

public class Cookbook : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public ICollection<CookbookRecipe> Recipes { get; set; } = []; 
}