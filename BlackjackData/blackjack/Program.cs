class Program
{
    static void Main(string[] args)
    {
        string round;

        Console.WriteLine("Welcome to Blackjack!");
        // Instantiate Game class
        Game g = new Game();
        Chip c = new Chip();
        
        c.WriteChipCount();

        Console.WriteLine("Would you like to play a round? [Y/N]: ");
        round = Console.ReadLine().ToLower();
        // input validation
        while(round != "y" && round != "n")
            {
                Console.WriteLine("Sorry, that is not a valid input. Please input [Y/N]");
                round = Console.ReadLine().ToLower();
            }
        // round loop
        if(round == "y")
                g.playRound();
                
        Console.WriteLine("\nThanks for playing!");
    }   
}