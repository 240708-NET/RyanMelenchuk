using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BlackjackData.Models;
using BlackjackData.Repo;

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

        // connect to db
        IRepository file = new EFCore();

        // create list to track players
        List<Player> playerList = new List<Player>();
        playerList = file.LoadAllPlayers();
        // load all existing ducks into the playerList ELSE IF there are no existing players - create one
        if(playerList.Count() == 0) // no existing players, create new player
        {
            Player p1 = new Player(50);
            playerList.Add(p1);
            Console.WriteLine("New Player Created");
            file.CreatePlayer(p1); // add player to DB
        }

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