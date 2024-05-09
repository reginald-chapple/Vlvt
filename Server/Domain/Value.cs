using System.ComponentModel.DataAnnotations;

namespace Server.Domain;

public class Value : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string Details { get; set; } = string.Empty;

    public string OrganizationId { get; set; } = string.Empty;
    public virtual Organization? Organization { get; set; }
}