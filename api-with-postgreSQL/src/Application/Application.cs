using Domain;
using Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;

namespace Application;

public class Application : IApplication
{
    private readonly OperationalContext _context;

    public Application(OperationalContext context)
    {
        _context = context;
    }

    public async Task<User[]> GetAllUsersAsync()
    {
        await using OperationalContext context = _context;

        return await context.Users.ToArrayAsync();
    }
    
    public async Task AddUserAsync(string name)
    {
        await using OperationalContext context = _context;
        
        context.Users.Add(new User
        {
            Name = name
        });

        await context.SaveChangesAsync();
    }
}