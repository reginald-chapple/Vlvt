using System.ComponentModel;

namespace Server.Domain;

public class Ingredient : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public IngredientCategory Category { get; set; }

    public long InstructionId { get; set; }
    public virtual Instruction? Instruction { get; set; }

}

public enum IngredientCategory
{
    [Description("Meat")]
    Meat,
    [Description("Seafood")]
    Seafood,
    [Description("Vegetable")]
    Vegetable,
    [Description("Fruit")]
    Fruit,
    [Description("Grain")]
    Grain,
    [Description("Dairy")]
    Dairy,
    [Description("Herb")]
    Herb,
    [Description("Spices")]
    Spice,
    [Description("Condiment")]
    Condiment,
    [Description("Nut")]
    Nut,
    [Description("Seed")]
    Seed,
}