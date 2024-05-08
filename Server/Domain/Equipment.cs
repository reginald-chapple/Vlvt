namespace Server.Domain;

public class Equipment : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    // public EquipmentCategory Category { get; set; }
    
    public long RecipeId { get; set; }
    public virtual Recipe? Recipe{ get; set; }

}

public enum EquipmentCategory
{
    Cookware,
    Bakeware,
    Utensils,
    Appliances,
    Miscellaneous,
    Specialized
}