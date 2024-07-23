using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BlackjackData.Models;

namespace Blackjack;

class Program
{
    static void Main(string[] args)
    {
        string round;

        Console.WriteLine("Welcome to Blackjack!");
        // Instantiate classes
        Game g = new Game();
        Chip c = new Chip();
        // TODO - create IF statement where if the player already exists,
        //        then just create a new p1 instance of the player from the Blackjack DB
        Player p1 = new Player{ID = 1, chips = 50};
        
        // connect to db
        using(var context = new DataContext())
        {
            context.Add(p1);
            context.SaveChanges();
        }
        /*
        string connectionString = "./connectionstring";
        DbContextOptions<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(connectionString).Options;
        DataContext Context = new DataContext(ContextOptions);
        */

        c.WriteChipCount();

        Console.WriteLine("Would you like to play a round? [Y/N]: ");
        round = Console.ReadLine().ToLower();
        // input validation
        while(round != "y" && round != "n")
            {
                Console.WriteLine("Sorry, that is not a valid input. Please input [Y/N]");
                round = Console.ReadLine().ToLower();
            }
        // round loop
        if(round == "y")
                g.playRound();
                
        Console.WriteLine("\nThanks for playing!");
    }   
}