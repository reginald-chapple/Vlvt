using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Server.Domain;

public class Fundraiser : AuditableEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsClosed { get; set; } = false;

    [Precision(9, 2)]
    public decimal Goal { get; set; } = 0.0m;

    [DataType(DataType.Text)]
    public string Purpose { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateOnly? Deadline { get; set; }

    public DateTime? ClosedDateTime { get; set; } = null;

    public string OrganizationId { get; set; } = string.Empty;
    public virtual Organization? Organization{ get; set; }

    public ICollection<Donation> Donations { get; set; } = [];

    public decimal Fundsraised()
    {
        return Donations.Sum(d => d.Amount);
    }

    public decimal FundsNeeded()
    {
        return Goal - Donations.Sum(d => d.Amount);
    }
}