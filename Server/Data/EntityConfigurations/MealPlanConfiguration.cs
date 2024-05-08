using Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Server.Data.EntityConfigurations;
public class MealPlanConfiguration : IEntityTypeConfiguration<MealPlan>
{
    public void Configure(EntityTypeBuilder<MealPlan> builder)
    {
        builder.HasKey(x => new { x.MealId, x.PlanId });

        builder.HasOne(x => x.Meal)
            .WithMany(a => a.Plans)
            .HasForeignKey(x => x.MealId)
            .IsRequired();

        builder.HasOne(x => x.Plan)
            .WithMany(a => a.Meals)
            .HasForeignKey(x => x.PlanId)
            .IsRequired();
    }
}
