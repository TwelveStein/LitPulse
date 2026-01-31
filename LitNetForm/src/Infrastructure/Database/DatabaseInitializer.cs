using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class DatabaseInitializer(AppDbContext appDbContext)
{
    public void Initialize()
    {
        appDbContext.Database.Migrate();
        appDbContext.Database.EnsureCreated();
    }
}