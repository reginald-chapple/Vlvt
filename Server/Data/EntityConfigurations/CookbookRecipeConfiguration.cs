using Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Server.Data.EntityConfigurations;
public class CookbookRecipeConfiguration : IEntityTypeConfiguration<CookbookRecipe>
{
    public void Configure(EntityTypeBuilder<CookbookRecipe> builder)
    {
        builder.HasKey(x => new { x.CookbookId, x.RecipeId });

        builder.HasOne(x => x.Cookbook)
            .WithMany(a => a.Recipes)
            .HasForeignKey(x => x.CookbookId)
            .IsRequired();

        builder.HasOne(x => x.Recipe)
            .WithMany(a => a.Cookbooks)
            .HasForeignKey(x => x.RecipeId)
            .IsRequired();
    }
}
