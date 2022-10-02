namespace Domain;

public class User : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}