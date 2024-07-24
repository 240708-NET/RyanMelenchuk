using Microsoft.EntityFrameworkCore;
using BlackjackData.Models;

namespace BlackjackData.Repo;

// Creates local context for a specified database from a given connection string
public class DataContext : DbContext
{
    // Set Player objects into Players table
    public DbSet<Player> Players => Set<Player>();

    //public DataContext(DbContextOptions<DataContext> options) : base(options){};

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = File.ReadAllText("C:/Revature/RyanMelenchuk/BlackjackData/BlackjackData.Repo/connectionstring");
        optionsBuilder.UseSqlServer(connectionString);
    }
}