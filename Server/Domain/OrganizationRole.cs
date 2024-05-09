namespace Server.Domain;

public class OrganizationRole : AuditableEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; } = string.Empty;

    public string OrganizationId { get; set; } = string.Empty;
    public virtual Organization? Organization{ get; set; }

    public ICollection<MemberRole> Members { get; set; } = [];
}