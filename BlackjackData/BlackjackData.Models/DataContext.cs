using Microsoft.EntityFrameworkCore;

namespace BlackjackData.Models;

public class DataContext : DbContext
{
    public DbSet<Player> Player => Set<Player>();

    string ConnectionString = File.ReadAllText("C:/Revature/RyanMelenchuk/BlackjackData/BlackjackData.Models/connectionstring");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
}