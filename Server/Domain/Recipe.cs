namespace Server.Domain;

public class Recipe : AuditableEntity
{
    public long Id { get; set; }

    public string Label { get; set; } = string.Empty;

    public string EstimatedTime { get; set; } = string.Empty;

    public Complexity Complexity { get; set; }

    public Cuisine Cuisine { get; set; }

    public DietaryPreference DietaryPreference { get; set; }

    public MealComponent MealComponent { get; set; }

    public Occasion Occasion { get; set; }

    public Seasonality Seasonality { get; set; }

    public ServingTemperature ServingTemperature { get; set; }

    public Spiciness Spiciness { get; set; }
    
    public Taste Taste { get; set; }

    public ICollection<CookbookRecipe> Cookbooks { get; set; } = [];
    public ICollection<MealRecipe> Meals { get; set; } = [];
    public ICollection<Instruction> Instructions { get; set; } = [];
    public ICollection<Equipment> Equipment { get; set; } = [];

}
