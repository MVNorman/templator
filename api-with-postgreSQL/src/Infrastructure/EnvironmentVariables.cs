#pragma warning disable CS8603
namespace Infrastructure;

public sealed class EnvironmentVariables
{
    public static readonly EnvironmentVariables Environment = new("ASPNETCORE_ENVIRONMENT");

    public string Name { get; }

    public EnvironmentVariables(string name)
    {
        Name = name;
    }

    public string GetValue()
    {
        return System.Environment.GetEnvironmentVariable(Name);
    }
}