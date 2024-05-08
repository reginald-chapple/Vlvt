using System.ComponentModel;

namespace Server.Domain;

public enum DietaryPreference
{
    [Description("None")]
    None,   
    [Description("Vegetarian")]
    Vegetarian,
    [Description("Vegan")]
    Vegan,
    [Description("Gluten-free")]
    GlutenFree,
    [Description("Dairy-free")]
    DairyFree,
    [Description("Nut-free")]
    NutFree,
    [Description("Low-carb")]
    LowCarb,
    [Description("Keto")]
    Keto,
    [Description("Paleo")]
    Paleo,   
    [Description("Pescatarian")]
    Pescatarian
}