public class Game
{
    // Declare Game variables
    string play = "y";
    bool bust = false;

    // Instantiate Deck and Chip classes
    Deck d = new Deck();
    Chip c = new Chip();

    public Game(){}

    public void playRound()
    {
        // Loops (keeps dealing more hands of Blackjack) until the player decides to stop
        while(play == "y"){

            d.Deal();

            Console.WriteLine(" Hit or Stand [H/S]: ");
            string hos = Console.ReadLine().ToLower();
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
                // check if the player busted

                // check if the player hit blackjack

                // otherwise, ask the player again if they want to hit or stand
                d.Hit(d.playerHand);
            }
            else if(hos == "s")
            {
                Console.WriteLine("");
            }

            // Asks the user if they would like to play another round (loops)
            Console.WriteLine("Would you like to go again? [Y/N]: ");
            play = Console.ReadLine().ToLower();
            // Input validation
            while(play != "y" && play != "n"){
                Console.WriteLine("Sorry, that is not a valid input. Please input [Y/N]");
                play = Console.ReadLine().ToLower();
            }
        }
    }
}