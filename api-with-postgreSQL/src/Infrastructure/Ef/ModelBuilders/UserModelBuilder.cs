using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Ef.ModelBuilders;

public static class UserModelBuilder
{
    public static void BuildUsers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(x =>
        {
            x.HasKey(p => p.Id);

            x.Property(p => p.Id).ValueGeneratedOnAdd();
        });
    }
}