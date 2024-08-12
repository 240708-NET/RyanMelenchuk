class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");
        // Instantiate Game class
        Game g = new Game();
        Chip c = new Chip();
        
        c.writeChipCount();

        Console.WriteLine("Would you like to play a round? [Y/N]: ");
        String round = Console.ReadLine().ToLower();
        if(round == "y")
        {
            g.playRound();
        }
        
        Console.WriteLine("Thanks for playing!");        
    }
}