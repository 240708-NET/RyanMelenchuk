//using System;
//using System.Collections.Generic;

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
        //dealerHand = "";

        // Shuffles the deck if there are no cards left
        if(deckList.Count <= 0)
            Shuffle();

        // deal cards to player
        deckIndex = rand.Next(deckList.Count);
        playerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        deckIndex = rand.Next(deckList.Count);
        playerHand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.Write($"You have been dealt a {playerHand[0]} and {playerHand[1]}.");
        /*
        playerHand += DealCard(playerHand, 2);
        Console.WriteLine($"You have been dealt {playerHand}");
        //Console.WriteLine("DeckList Count: " + deckList.Count());
        dealerHand += DealCard(dealerHand, 2);
        Console.WriteLine($"The Dealer has {dealerHand}");
        */


        // check blackjack conditions
        // player hits blackjack (21)

        // dealer hits blackjack (21)

    }

    // 'Hits' the player w/ a card from the dealer
    public void Hit(List<string> hand)
    {
        if(deckList.Count <= 0)
            Shuffle();
        deckIndex = rand.Next(deckList.Count);
        hand.Add(deckList[deckIndex]);
        deckList.RemoveAt(deckIndex);
        Console.WriteLine($"You have been dealt a {hand[hand.Count()-1]}");
    }

    // The player chooses to 'Stand' so the dealer deals to himself. Player either busts or wins chips
    public void Stand()
    {
        
    }
}