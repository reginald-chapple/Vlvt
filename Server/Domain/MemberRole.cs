namespace Server.Domain;

public class MemberRole : Entity
{
    public string RoleId { get; set; } = string.Empty;
    public virtual OrganizationRole? Role{ get; set; }

    public string MemberId { get; set; } = string.Empty;
    public virtual Member? Member { get; set; }
}