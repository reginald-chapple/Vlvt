using System.ComponentModel.DataAnnotations;

namespace Server.Domain;

public class Organization : AuditableEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; } = string.Empty;

    public string Faith { get; set; } = string.Empty; 

    [DataType(DataType.Text)]
    public string Background { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string Message { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string Mission { get; set; } = string.Empty;

    public ICollection<Member> Members { get; set; } = [];

    public ICollection<OrganizationRole> Roles { get; set; } = [];

    public ICollection<Belief> Beliefs { get; set; } = [];

    public ICollection<Meeting> Meetings { get; set; } = [];
    
    public ICollection<Value> Values { get; set; } = [];
}