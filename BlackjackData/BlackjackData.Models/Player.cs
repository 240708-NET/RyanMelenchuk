using Microsoft.EntityFrameworkCore;

namespace BlackjackData.Models;

public class Player
{
    int id = 0;
    public int ID {get; set;}
    public int wins {get;set;} = 0;
    public int losses {get;set;} = 0;
    public int blackjacks {get;set;} = 0;
    public int chips {get;set;} = 0;
    public int chipsWon {get;set;} = 0;
    public int chipsLost {get;set;} = 0;
    
    // Do not add ID into constructor(s) because SQL Server adds one by default
    public Player(int startingChips)
    {
        id++;
        this.ID = id;
        this.chips = startingChips;
    }

    public Player(){}
}
