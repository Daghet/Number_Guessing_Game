Project Summary for GitHub
Project Title: Number Guessing Game (C# Console App)
Description:
A console-based Number Guessing Game built in C# as part of my software engineering learning journey. This project features two engaging modes:
CompPicks Mode: The computer generates a random number between 1 and 100, and the player tries to guess it. Feedback ("Too high!" or "Too low!") guides the player, with the number of attempts tracked and displayed (e.g., "You got that in 5 attempts!").

PlayerPicks Mode: The player selects a number, and the computer guesses using a random strategy within a narrowing range. The player provides feedback ("Too high!", "Correct!", or "Too low!"), and the computer counts its guesses, ending with a message like "That only took me 3 tries!".

Features:
Interactive menu with options to play either mode or exit.

Robust input validation using int.TryParse to handle non-numeric or out-of-range inputs.

Guess counter with singular/plural support ("attempt"/"attempts" in CompPicks, "try"/"tries" in PlayerPicks).

Range validation in PlayerPicks to detect inconsistent feedback with a helpful error message.

Modular design with separate methods for game logic and guess checking.

Skills Learned:
C# basics: variables, loops, conditionals, and console I/O.

Error handling with try-catch and int.TryParse.

Random number generation and basic game logic.

String interpolation and ternary operators for dynamic output.

How to Run:
Clone this repository.

Open the project in a C# IDE (e.g., Visual Studio or VS Code with C# extension).

Build and run Program.cs.

Follow the menu prompts to play!

Future Enhancements:
Implement a binary search algorithm in PlayerPicks for smarter guessing.

Add a maximum guess limit to challenge players.

Include a replay option without exiting.

Author: Geoff Walsh
Date: March 2025
