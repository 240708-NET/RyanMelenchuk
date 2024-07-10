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
        // Shuffles the deck
        //d.Shuffle();
        // Loops (keeps dealing more hands of Blackjack) until the player decides to stop
        while(play == "y"){
            








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