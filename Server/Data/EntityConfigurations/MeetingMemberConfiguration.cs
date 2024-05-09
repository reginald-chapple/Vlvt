using Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Server.Data.EntityConfigurations;
public class MeetingMemberConfiguration : IEntityTypeConfiguration<MeetingMember>
{
    public void Configure(EntityTypeBuilder<MeetingMember> builder)
    {
        builder.HasKey(x => new { x.MemberId, x.MeetingId });

        builder.HasOne(x => x.Member)
            .WithMany(a => a.Meetings)
            .HasForeignKey(x => x.MemberId)
            .IsRequired();

        builder.HasOne(x => x.Meeting)
            .WithMany(a => a.Members)
            .HasForeignKey(x => x.MeetingId)
            .IsRequired();
    }
}
