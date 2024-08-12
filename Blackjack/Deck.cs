// The deck will responsively decrease as cards are dealt
// The deck will shuffle once it is sufficiently depleted


public class Deck
{
    // Initial Deck array for each card in a standard deck of cards
    List<string> deckList = new List<string>();
    static string[] fullDeck = {"A", "A", "A", "A", "2", "2", "2", "2", "3", "3", "3", "3", "4", "4", "4", "4", "5", "5", "5", "5", 
                        "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "10", 
                        "J", "J", "J", "J", "Q", "Q", "Q", "Q", "K", "K", "K", "K"};
    //public string[] currentDeck {get;set;} = fullDeck;
    public List<string> playerHand {get;set;} = new List<string>();
    public List<string> dealerHand {get;set;} = new List<string>();

    Random rand = new Random();
    int deckIndex;

    public Deck()
    {
        Shuffle();
    }

    // Shuffles/Randomizes the Deck array
    public void Shuffle()
    {
        deckList.Clear();
        deckList.AddRange(fullDeck);
        Console.WriteLine("Deck Shuffled");
    }

    public string DealCard(string hand, int numCards)
    {
        for(int i = 0; i < numCards; i++)
        {
        deckIndex = rand.Next(deckList.Count);
        hand += deckList[deckIndex];
        deckList.RemoveAt(deckIndex);
        }
        return hand;
    }

    // 'Deals' the initial hand for the player and dealer
    public void Deal()
    {
        playerHand.Clear();

        // Shuffles the deck if there are no cards left
        if(deckList.Count < 2)
            Shuffle();

        // deal cards to player
        deckIndex = rand.Next(deckList.Count);
        playerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        deckIndex = rand.Next(deckList.Count);
        playerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.Write($"You have been dealt a {playerHand[0]} and {playerHand[1]}.");
    }

    public void DealerDeal()
    {
        dealerHand.Clear();

        if(deckList.Count < 2)
            Shuffle();

        deckIndex = rand.Next(deckList.Count);
        dealerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        deckIndex = rand.Next(deckList.Count);
        dealerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.Write($" The dealer has a {dealerHand[1]}.");
    }

    // Returns the value of a hand
    public int Count(List<string> hand)
    {
        int count = 0;
        // iterate through the cards in a hand
        for(int i = 0; i < hand.Count(); i++)
        {
            if(hand[i] == "A" && count <= 10)
                count += 11;
            else if(hand[i] == "A" && count > 10)
                count += 1;
            else if(hand[i] == "2")
                count += 2;
            else if(hand[i] == "3")
                count += 3;
            else if(hand[i] == "4")
                count += 4;
            else if(hand[i] == "5")
                count += 5;
            else if(hand[i] == "6")
                count += 6;
            else if(hand[i] == "7")
                count += 7;
            else if(hand[i] == "8")
                count += 8;
            else if(hand[i] == "9")
                count += 9;
            else if(hand[i] == "10" || hand[i] == "J" || hand[i] == "Q" || hand[i] == "K")
                count += 10;
        }
        return count;
    }

    // 'Hits' the player w/ a card from the dealer
    public void PlayerHit(List<string> hand)
    {
        if(deckList.Count <= 0)
            Shuffle();
        deckIndex = rand.Next(deckList.Count);
        hand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.WriteLine($"You have been dealt a {hand[hand.Count()-1]}");
    }

    public void DealerHit(List<string> hand)
    {
        if(deckList.Count <= 0)
            Shuffle();
        deckIndex = rand.Next(deckList.Count);
        hand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.WriteLine($"The dealer has been dealt a {hand[hand.Count()-1]}");
    }
}