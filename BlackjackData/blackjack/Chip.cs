// The user will be able to bet chips
// If the user gets a natural (blackjack) they get their back their amount of chips bet x1.5
// The user will be able to "cash out" their chips for cash, quitting the game
// The user will be able to "cash in" if they run out of chips to continue playing

public class Chip
{
    // Starting chip count for the player
    static int startChips = 50;
    int cash = 1000;
    public int playerChips {get;set;} = startChips;
    public int betChips;

    public void WriteChipCount()
    {
        Console.WriteLine($"You have {playerChips} chips.");
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

    public void UpdateChips(bool blackjack, bool won)
    {
        if(blackjack)
            playerChips += (int)Math.Round(betChips*1.5);
        else if(won)
            playerChips += betChips;
        else
            playerChips -= betChips;
    }
    public void UpdateChips(bool blackjack)
    {
        if(blackjack)
            playerChips += (int)Math.Round(betChips*1.5);
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