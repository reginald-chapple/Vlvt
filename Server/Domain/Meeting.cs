using System.ComponentModel.DataAnnotations;

namespace Server.Domain;

public class Meeting : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string Details { get; set; } = string.Empty;

    public string Location { get; set;} = string.Empty;

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string OrganizationId { get; set; } = string.Empty;
    public virtual Organization? Organization { get; set; }

    public ICollection<MeetingMember> Members { get; set; } = [];

}