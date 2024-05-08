namespace Server.Domain;

public class Instruction : AuditableEntity
{
    public long Id { get; set; }

    public string Label { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;

    public int Step { get; set; }

    public int? Temperature { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Duration { get; set; }

    public InstructionDurationInterval DurationInterval { get; set; }

    public ICollection<Ingredient> Ingredients { get; set; } = [];
}

public enum InstructionDurationInterval
{
    Seconds, Minutes, Hours, Days
}