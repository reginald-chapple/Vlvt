using System.ComponentModel;

namespace Server.Domain;

public enum MealComponent
{
    [Description("Beverage")]
    Beverage,
    [Description("Snack")]
    Snack,
    [Description("Appetizer")]
    Appetizer,
    [Description("Entrée")]
    Entree,
    [Description("Side dish")]
    SideDish,
    [Description("Dessert")]
    Dessert,
}