using System;

namespace NumberGuessingGame
{
    class Program
    {
        public static void Main(string[] args)
        {    
            // Generate Random Number
            Random random = new Random();
            int target = random.Next(1, 101);
            int guess;

            bool running = true;

            Console.WriteLine(target);

            while (running)
            {
                Console.Write("Enter a number between 1 and 100: ");
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid guess, please enter a number between 1 and 100.");
                    return;
                }

                if (guess > 100 || guess < 0)
                {
                    Console.WriteLine("Invalid guess, please enter a number between 1 and 100.");
                } 
                else
                {
                    running = !CheckGuess(guess, target);  
                }                      
            }            
        }

        // Method for checking guess against target
        public static bool CheckGuess(int guess, int target)
        {
            bool gameOver = false;

            if (guess == target)
            {
                Console.WriteLine("You guessed correctly!");
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