// The user will be able to bet chips
// The user will be able to "cash out" their chips for cash, quitting the game
// The user will be able to "cash in" if they run out of chips to continue playing

public class Chip
{
    // Starting chip count for the player
    static int baseChips = 50;
    public int playerChips {get;set;} = baseChips;

    public void writeChipCount()
    {
        Console.WriteLine($"You have {playerChips} chips available.");
    }

    // Cashes out the player and shows them how much they have won (or lost). Quits the game
    public void CashOut(int playerChips)
    {

    }

    // The player cashes more money into chips to continue playing if they run out of chips
    public void CashIn(int Cash)
    {

    }
}