using Domain.Models;

namespace Domain;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public int Age { get; set; }
    public List<Address> Addresses { get; set; } = new();
    public List<Email> EmailAddresses { get; set; } = new();

}
