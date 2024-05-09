namespace Server.Domain;

public class Member : AuditableEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string OrganizationId { get; set; } = string.Empty;
    public virtual Organization? Organization{ get; set; }

    public string IdentityId { get; set; } = string.Empty;
    public virtual ApplicationUser? Identity{ get; set; }

    public ICollection<MemberRole> Roles { get; set; } = [];

    public ICollection<MeetingMember> Meetings { get; set; } = [];
}