using Common.Enums;

namespace Domain.Entities;

public class SampleEntity_Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
}