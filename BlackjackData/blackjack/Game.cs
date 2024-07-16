// The user will be able to play through at least one round of blackjack
// The user will be have the option to play another round if they so choose
// The user will be able to exit the game if they no longer wish to continue playing
// The user will be dealt and presented cards according to the rules of blackjack
// The user will be able to 'Hit' or 'Stand'
// The user will win if they hit blackjack, score >= the dealer, or the dealer busts
// The user will lose if they score lower than the dealer or bust

using BlackjackData.Repo;
using BlackjackData.Models;

public class Game
{
    // Declare Game variables
    string play = "y";
    string hos = "";
    bool bust = false;
    bool blackjack = false;
    bool dealerBust = false;
    int playerCount = 0;
    int dealerCount = 0;
    // Instantiate Deck and Chip classes
    Deck d = new Deck();
    Chip c = new Chip();

    public Game(){}

    public void playRound()
    {
        // Loops (keeps dealing more hands of Blackjack) until the player decides to stop
        while(play == "y")
        {
            // reset variables for new round
            bust = false;
            blackjack = false;
            hos = "";
            c.WriteChipCount();
            c.BetChips();
            d.Deal();
            d.DealerDeal();
            dealerCount = d.Count(d.dealerHand);
            // counts the players card value
            playerCount = d.Count(d.playerHand);
            Console.WriteLine(" Count = " + playerCount);
            // check if the player hit blackjack
            if(playerCount == 21)
            {
                c.UpdateChips(true);
                Console.WriteLine($"\nBlackjack! You won {c.betChips} chips.");
                blackjack = true;
            }
            // check if the dealer hit blackjack
            else if(dealerCount == 21)
            {
                c.UpdateChips(false,false);
                Console.WriteLine("\nDealer Blackjack! Better luck next time...");
            }
            else
            {
                while(bust == false && hos != "s")
                {
                    // ask the player to hit or stand
                    Console.WriteLine("Hit or Stand [H/S]: ");
                    hos = Console.ReadLine().ToLower();
                    if(hos != "h" && hos != "s")
                    {
                        while(hos != "h" && hos != "s")
                        {
                            Console.WriteLine("Sorry, that is not a valid input. Please input [H/S]");
                            hos = Console.ReadLine().ToLower();
                        }
                    }
                    if(hos == "h")
                    {
                        d.PlayerHit(d.playerHand);
                        playerCount = d.Count(d.playerHand);
                        Console.Write(" Count = " + playerCount + ". ");
                        // check if the player busted
                        if(playerCount > 21)
                        {
                            c.UpdateChips(false,false);
                            Console.WriteLine("\nBusted!");
                            bust = true;
                        }
                        else if(playerCount == 21)
                        {
                            blackjack = true;
                            c.UpdateChips(blackjack);
                            Console.WriteLine($"\nBlackjack! You won {c.betChips} chips.");
                            break;
                        }                      
                    }
                    
                }
                // if no one hits blackjack and the player is done hitting or chooses to stand, the dealer plays
                if(bust == false && blackjack == false)
                {
                    // the dealer deals to himself after the player hits/stands
                    Console.WriteLine($"The dealer has a {d.dealerHand[0]} and {d.dealerHand[1]}");
                    while(dealerBust == false)
                    {
                        dealerCount = d.Count(d.dealerHand);
                        //Console.Write(". Current Dealer Count: " + dealerCount);
                        if(dealerCount > 21)
                        {
                            c.UpdateChips(false,true);
                            Console.WriteLine($"\nDealer Busted! You won {c.betChips} chips.");
                            dealerBust = true;
                        }
                        else if(dealerCount == 21)
                        {
                            c.UpdateChips(false,false);
                            Console.WriteLine("\nDealer Blackjack! Better luck next time...");
                            break;
                        }
                        else if(dealerCount > playerCount)
                        {
                            c.UpdateChips(false,false);
                            Console.WriteLine($"\nYou have {playerCount} while the Dealer has {dealerCount}. Close!");
                            break;
                        }
                        else if(dealerCount <= playerCount && dealerCount >= 17)
                        {
                            c.UpdateChips(false,true);
                            Console.WriteLine($"\nYou have {playerCount} while the Dealer has {dealerCount}. You won {c.betChips} chips.");
                            break;
                        }
                        else
                        {
                            d.DealerHit(d.dealerHand);
                        }                    
                    }
                }
            }
            // Asks the user if they would like to play another round (loops)
            Console.WriteLine("\nWould you like to go again? [Y/N]: ");
            play = Console.ReadLine().ToLower();
            // Input validation
            while(play != "y" && play != "n"){
                Console.WriteLine("Sorry, that is not a valid input. Please input [Y/N]");
                play = Console.ReadLine().ToLower();
            }
        }
    }
}