using System.ComponentModel;

namespace Server.Domain;

public enum CookingMethod
{
    Grilling,
    Roasting,
    Baking,
    Boiling,
    Steaming,
    [Description("Sautéing")]
    Sauteing,
    [Description("Stir-frying")]
    StirFrying,
    [Description("Deep-frying")]
    DeepFrying,
    [Description("Pan-frying")]
    PanFrying,
    Griddling,
    Broiling,
    Poaching,
    Braising,
    Smoking,
    Curing
}
