
public class Program{

	static void Main(string[] args){
	
		Console.WriteLine("Hello!");

		Console.WriteLine("Please enter your name for a personalized greeting: ");
		String userName; //instantiate userName variable
		userName = Console.ReadLine(); //assign userName variable to user input
		
		//String Concatenation
		//Console.WriteLine("Welcome to Revature, " + userName + "!");
		
		//String Interpolation
		//Console.WriteLine("Welcome to Revature, {0}!", userName);
		
		//String Formatting - $ to call variables in {} into String
		Console.WriteLine($"Welcome to Revature, {userName}!");
	}
}
