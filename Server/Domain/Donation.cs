using Microsoft.EntityFrameworkCore;

namespace Server.Domain;

public class Donation : AuditableEntity
{
    public Donation() {}
    
    public long Id { get; set; }

    [Precision(8, 2)]
    public decimal Amount { get; set; } = 0.0m;

    public long FundraiserId { get; set; }
    public virtual Fundraiser? Fundraiser { get; set; }

}