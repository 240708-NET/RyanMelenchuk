// The user will be able to bet chips
// If the user gets a natural (blackjack) they get their back their amount of chips bet x1.5
// The user will be able to "cash out" their chips for cash, quitting the game
// The user will be able to "cash in" if they run out of chips to continue playing

using BlackjackData.Models;
using BlackjackData.Repo;

namespace Blackjack;

public class Chip
{
    IRepository file = new EFCore();
    // Starting chip count for the player
    public int betChips = 0;

    public Chip (){}

    public void WriteChipCount()
    {
        int numChips = file.GetChipsByID(1);
        Console.WriteLine($"You have {numChips} chips.");
    }

    public void BetChips()
    {
        Console.WriteLine("How much are you betting?: ");
        int chipInput = 0;
        chipInput = Int32.Parse(Console.ReadLine());
        while(chipInput == 0){
            Console.WriteLine("Sorry, that is not a valid input. Please input a number.");
            chipInput = Int32.Parse(Console.ReadLine());
        }
        betChips = chipInput;
    }

    public void UpdateChips(Player player, bool blackjack, bool won)
    {
        if(blackjack)
            player.chips += (int)Math.Round(betChips*1.5);
        else if(won)
            player.chips += betChips;
        else
            player.chips -= betChips;
        file.UpdatePlayer(player);
    }
    public void UpdateChips(Player player, bool blackjack)
    {
        if(blackjack)
            player.chips += (int)Math.Round(betChips*1.5);
        file.UpdatePlayer(player);
    }
    /*
    // Cashes out the player and shows them how much they have won (or lost). Quits the game
    public void CashOut(int numChips)
    {
        playerChips -= numChips;
        cash += playerChips*10;
    }

    // The player cashes more money into chips to continue playing if they run out of chips
    public void CashIn(int cashAmount)
    {
        cash -= cashAmount;
        playerChips += cashAmount%10;
    }
    */
}