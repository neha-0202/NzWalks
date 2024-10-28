using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NzWalksApi.Data;

public class NzWalksDbContextFactory : IDesignTimeDbContextFactory<NzWalksDbContext>
{
    public NzWalksDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<NzWalksDbContext>();
        optionsBuilder.UseSqlServer("YourConnectionStringHere");

        return new NzWalksDbContext(optionsBuilder.Options);
    }
}

