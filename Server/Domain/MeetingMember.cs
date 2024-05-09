namespace Server.Domain;

public class MeetingMember : Entity
{
    public string MemberId { get; set; } = string.Empty;
    public virtual Member? Member { get; set; }

    public long MeetingId { get; set; }
    public virtual Meeting? Meeting { get; set; }
}