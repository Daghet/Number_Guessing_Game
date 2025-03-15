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
                        compPicks();
                        break;
                    
                    case "2":
                        playerPicks();
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

        public static void compPicks()
        {
            // Generate Random Number
            Random random = new Random();
            int target = random.Next(1, 101);
            int guesses = 0;
            int guess = -1;

            bool running = true;
            
            Console.WriteLine("I've selected a number between 1 and 100, can you guess it?");

            while (running)
            {
                Console.Write("Enter a number between 1 and 100: ");
                bool validInput = true;
                
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid guess, please enter a number between 1 and 100.");
                    validInput = false;
                }

                if (!validInput || guess > 100 || guess < 0)
                {
                    Console.WriteLine("Invalid guess, please enter a number between 1 and 100.");
                    validInput = false;
                } 
                else if (validInput)
                {
                    running = !CheckGuess(guess, target);
                    guesses++;
                }                   
            }

            Console.WriteLine($"You guessed correctly in {guesses} attempts!");
        }

        public static void playerPicks()
        {
            Console.WriteLine();
            Console.WriteLine("Ok, pick a number between 1 and 100.");
            Random random = new Random();
            int low = 1;
            int high = 100; 
            int guesses = 0;  
            string tryOrTries = "tries";                    

            bool running = true;      

            int guess = random.Next(low, high); 
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
                        guesses++; 
                        high = guess - 1;
                        guess = random.Next(low, high);
                        Console.WriteLine($"I guess... {guess}.");                  
                        break;

                    case "2":                        
                        guesses++;
                        running = false;
                        break;

                    case "3":
                        guesses++;
                        low = guess + 1;
                        guess = random.Next(low, high);
                        Console.WriteLine($"I guess... {guess}.");
                        break;
                    
                    default:
                        Console.WriteLine("Sorry, I don't understand, try again!");
                        Console.WriteLine($"My guess was {guess}.");
                        break;
                }
            }
            if (guesses == 1)
                {
                    tryOrTries = "try";
                }     
            else
                {
                    tryOrTries = "tries";
                } 
            Console.WriteLine($"God damn I'm good! That only took me {guesses} {tryOrTries}.");      
        }
        
        public static bool CheckGuess(int guess, int target)
        {
            bool gameOver = false;

            if (guess == target)
            {
                gameOver = true;
            }                
            else if (guess > target)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Too low! Try again.");
            }
            return gameOver;
        }
    }
}