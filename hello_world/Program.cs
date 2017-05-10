using System;

public class Program {
	static void Main() {
		Console.Write("Hello, what is your name: ");
		string username = Console.ReadLine();
		Console.Write("Hello " + username + " do you like fruitcake? ");
		string answer = Console.ReadLine();
		if (answer == "yes" || answer == "Yes") {
			Console.Write("You suck");
			Environment.Exit(0);
		} else {
			Console.Write("You rock!");
			Environment.Exit(0);
		};
	}
}
