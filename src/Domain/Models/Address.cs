namespace Domain.Models;

public class Address
{
    public int Id { get; set; }
    public string StreetAddress { get; set; } = default!;
    public string City { get; set; } = default!;
    public string State { get; set; } = default!;
    public string ZipCode { get; set; } = default!;
}