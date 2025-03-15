using System;

namespace NumberGuessingGame
{
    class Program
    {
        public static void Main(string[] args)
        {           
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("____Number Guessing Game____");
                Console.WriteLine("Which game do you want to play?");
                Console.WriteLine("1. I pick a number, you guess.");
                Console.WriteLine("2. You pick a number, and I guess.");
                Console.WriteLine("3. Exit.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CompPicks();
                        break;
                    
                    case "2":
                        PlayerPicks();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        running = false;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }                  
        }

        public static void CompPicks()
        {
            Random random = new Random();
            int target = random.Next(1, 101);
            int guesses = 0;

            Console.WriteLine("I've selected a number between 1 and 100, can you guess it?");

            while (true)
            {
                Console.Write("Enter a number between 1 and 100: ");
                if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1 || guess > 100)
                {
                    Console.WriteLine("Invalid guess, please enter a number between 1 and 100.");
                    continue;
                }

                guesses++;
                if (CheckGuess(guess, target))
                {
                    Console.WriteLine($"You got that in {guesses} {(guesses == 1 ? "attempt" : "attempts")}!");
                    break;
                }
            }
        }

        public static void PlayerPicks()
        {
            Console.WriteLine("Ok, pick a number between 1 and 100.");
            Random random = new Random();
            int low = 1;
            int high = 101; 
            int guesses = 0;  
            int guess = random.Next(low, high);
            bool running = true;

            Console.WriteLine($"I guess... {guess}.");

            while (running)
            {
                Console.WriteLine("1. Too high!");
                Console.WriteLine("2. Correct!");
                Console.WriteLine("3. Too low!");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        high = guess - 1;
                        if (low > high)
                        {
                            Console.WriteLine("I think you gave me the wrong feedback!");
                            return;
                        }
                        guess = random.Next(low, high + 1);
                        guesses++;
                        Console.WriteLine($"I guess... {guess}.");
                        break;

                    case "2":
                        guesses++;
                        Console.WriteLine($"God damn I'm good! That only took me {guesses} {(guesses == 1 ? "try" : "tries")}.");
                        running = false;
                        break;

                    case "3":
                        low = guess + 1;
                        if (low > high)
                        {
                            Console.WriteLine("I think you gave me the wrong feedback!");
                            return;
                        }
                        guess = random.Next(low, high + 1);
                        guesses++;
                        Console.WriteLine($"I guess... {guess}.");
                        break;

                    default:
                        Console.WriteLine("Sorry, I don't understand, try again!");
                        Console.WriteLine($"My guess was {guess}.");
                        break;
                }
            }
        }

        public static bool CheckGuess(int guess, int target)
        {
            if (guess == target)
            {
                Console.WriteLine("You guessed correctly!");
                return true;
            }
            Console.WriteLine(guess > target ? "Too high! Try again." : "Too low! Try again.");
            return false;
        }
    }
}