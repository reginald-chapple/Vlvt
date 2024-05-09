using Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Server.Data.EntityConfigurations;
public class MemberRoleConfiguration : IEntityTypeConfiguration<MemberRole>
{
    public void Configure(EntityTypeBuilder<MemberRole> builder)
    {
        builder.HasKey(x => new { x.MemberId, x.RoleId });

        builder.HasOne(x => x.Member)
            .WithMany(a => a.Roles)
            .HasForeignKey(x => x.MemberId)
            .IsRequired();

        builder.HasOne(x => x.Role)
            .WithMany(a => a.Members)
            .HasForeignKey(x => x.RoleId)
            .IsRequired();
    }
}
