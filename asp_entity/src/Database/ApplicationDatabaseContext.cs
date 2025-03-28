using Microsoft.EntityFrameworkCore;
using src.Models;

// Helpful minimal example: https://github.com/grpm98/pisofinderapi/blob/f114d5860c60267a05ccfd8ed41c162ce8e51224/Data/PisoFinderContext.cs
public class ApplicationDbContext : DbContext
{
     public DbSet<Example> Examples { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }
}