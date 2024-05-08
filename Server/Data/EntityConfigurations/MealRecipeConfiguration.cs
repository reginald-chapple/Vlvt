using Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Server.Data.EntityConfigurations
{
    public class MealRecipeConfiguration : IEntityTypeConfiguration<MealRecipe>
    {
        public void Configure(EntityTypeBuilder<MealRecipe> builder)
        {
            builder.HasKey(x => new { x.MealId, x.RecipeId });

            builder.HasOne(x => x.Meal)
                .WithMany(a => a.Recipes)
                .HasForeignKey(x => x.MealId)
                .IsRequired();

            builder.HasOne(x => x.Recipe)
                .WithMany(a => a.Meals)
                .HasForeignKey(x => x.RecipeId)
                .IsRequired();
        }
    }
}