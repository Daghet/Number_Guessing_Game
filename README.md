# Number Guessing Game (C# Console App)

## Description
A console-based **Number Guessing Game** built in C# as part of my software engineering learning journey. This project features two engaging modes:

- **CompPicks Mode**: The computer generates a random number between 1 and 100, and the player tries to guess it. Feedback ("Too high!" or "Too low!") guides the player, with the number of attempts tracked and displayed (e.g., "You got that in 5 attempts!").
- **PlayerPicks Mode**: The player selects a number, and the computer guesses using a random strategy within a narrowing range. The player provides feedback ("Too high!", "Correct!", or "Too low!"), and the computer counts its guesses, ending with a message like "That only took me 3 tries!".

## Features
- Interactive menu with options to play either mode or exit.
- Robust input validation using `int.TryParse` to handle non-numeric or out-of-range inputs.
- Guess counter with singular/plural support ("attempt"/"attempts" in CompPicks, "try"/"tries" in PlayerPicks).
- Range validation in PlayerPicks to detect inconsistent feedback with a helpful error message.
- Modular design with separate methods for game logic and guess checking.

## Skills Learned
- **C# Basics**: Variables, loops, conditionals, and console I/O.
- **Error Handling**: Using `try-catch` and `int.TryParse`.
- **Random Number Generation**: Using `Random` class for game logic.
- **String Interpolation**: Dynamic output with ternary operators.

## How to Run
1. Clone this repository.
2. Open the project in a C# IDE (e.g., Visual Studio or VS Code with C# extension).
3. Build and run `Program.cs`.
4. Follow the menu prompts to play!

## Example Gameplay
**Number Guessing Game**
Which game do you want to play?
1. I pick a number, you guess.
2. You pick a number, and I guess.
3. Exit.

## Future Enhancements
- Implement a binary search algorithm in `PlayerPicks` for smarter guessing.
- Add a maximum guess limit to challenge players.
- Include a replay option without exiting.

## Author
Geoff Walsh
**Date**: March 2025
