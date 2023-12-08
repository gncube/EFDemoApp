namespace Domain.Models;

public class Email
{
    public int Id { get; set; }
    public string EmailAddress { get; set; } = default!;
    public bool IsPrimary { get; set; }
}
