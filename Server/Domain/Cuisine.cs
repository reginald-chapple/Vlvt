using System.ComponentModel;

namespace Server.Domain;

public enum Cuisine
{
    [Description("Italian")]
    Italian,
    [Description("Mexican")]
    Mexican,
    [Description("Chinese")]
    Chinese,
    [Description("Indian")]
    Indian,
    [Description("French")]
    French,
    [Description("Japanese")]
    Japanese,
    [Description("Mediterranean")]
    Mediterranean,
    [Description("American")]
    American,
    [Description("Thai")]
    Thai,
    [Description("Greek")]
    Greek,
    [Description("Korean")]
    Korean,
    [Description("Spanish")]
    Spanish,
    [Description("Middle Eastern")]
    MiddleEastern,
    [Description("Fusion")]
    Fusion
}
