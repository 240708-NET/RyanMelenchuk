namespace BlackjackData.Models;

public class Player
{
    public int ID {get; set;}
    public int wins {get;set;} = 0;
    public int losses {get;set;} = 0;
    public int blackjacks {get;set;} = 0;
    public int chips {get;set;}
    public int chipsWon {get;set;} = 0;
    public int chipsLost {get;set;} = 0;

    public Player(int id, int startingChips){
        ID = id;
        chips = startingChips;
    }
}
