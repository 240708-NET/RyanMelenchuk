using Microsoft.EntityFrameworkCore;
using BlackjackData.Models;

namespace BlackjackData.Repo;

// Extends Repo Interface's CRUD & Data Manipulation methods for SQL Database
public class EFCore : IRepository
{
    // Initializes local DB context
    DataContext context;

    public EFCore(){
        /*
        DbContextOptions<DataContext> options;
        options = new DbContextOptionsBuilder<DataContext>().UseSqlServer(connectionString).Options;
        context = new DataContext(options);
        */
        context = new DataContext();
    }

    // implement IRepository methods
    public void CreatePlayer(Player newPlayer)
    {
        context.Players.Add(newPlayer);
        context.SaveChanges();
        Console.WriteLine("Player Inserted into DB");
    }

    public Player GetPlayerByID(int ID)
    {
        return context.Players.Find(ID);
    }

    public List<Player> LoadAllPlayers()
    {
        return context.Players.ToList();
    }

    public int GetChips(Player player)
    {
        var p = context.Players.Find(player.ID);
        return (int) p.chips;
    }

    public void UpdatePlayer(Player player)
    {
        Player savedPlayer = context.Players.Find(player.ID);

        if (savedPlayer != null)
        {
            savedPlayer.ID = player.ID;
            savedPlayer.wins = player.wins;
            savedPlayer.losses = player.losses;
            savedPlayer.blackjacks = player.blackjacks;
            savedPlayer.chips = player.chips;
            savedPlayer.chipsWon = player.chipsWon;
            savedPlayer.chipsLost = player.chipsLost;                    
            context.SaveChanges();
            //Console.WriteLine("Player Updated");
        }
    }

    public void DeletePlayerByID(int ID)
    {
        Player player = context.Players.Find(ID);
        context.Players.Remove(player);
        context.SaveChanges();
    }

}