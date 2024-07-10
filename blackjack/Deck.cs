public class Deck
{
    // Initial Deck array for each card in a standard deck of cards
    static string[] fullDeck = {"A", "A", "A", "A", "2", "2", "2", "2", "3", "3", "3", "3", "4", "4", "4", "4", "5", "5", "5", "5", 
                        "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "10", 
                        "J", "J", "J", "J", "Q", "Q", "Q", "Q", "K", "K", "K", "K"};
    public string[] currentDeck {get;set;} = fullDeck;

    
    // Shuffles/Randomizes the Deck array
    public void Shuffle()
    {

    }

    // 'Hits' the player w/ a card from the dealer
    public void Hit()
    {

    }

    // The player chooses to 'Stand' so the dealer deals to himself. Player either busts or wins chips
    public void Stand()
    {
        
    }
}