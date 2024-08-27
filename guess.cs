using System;

class Program
{
    static void Main()
    {
        // Initialize random number generator
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Number between 1 and 100
        int numberOfTries = 0;
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Welcome to 'Guess the Number'!");
        Console.WriteLine("I have chosen a number between 1 and 100. Can you guess it?");
        
        while (!hasGuessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            // Validate input
            if (int.TryParse(userInput, out int userGuess))
            {
                numberOfTries++;
                
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {numberOfTries} tries.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        // End of the game
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
