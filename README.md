# Slot Machine Game

Welcome to the Slot Machine Game! This console-based C# game allows users to simulate a slot machine experience, betting money and choosing different play options to win rewards.

## Table of Contents
- [Game Overview](#game-overview)
- [Features](#features)
- [How to Play](#how-to-play)
- [Function Breakdown](#function-breakdown)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)

---

## Game Overview

In this game, players start by entering an amount they'd like to gamble (between €1 and €100). They then choose a play option and begin spinning the slot machine. Each spin costs €1, and winning yields a reward based on the chosen play option. The game continues until the player decides to quit or runs out of money.

## Features

- **Multiple Play Options:** Players can choose from various play styles, including center line, all horizontal lines, vertical lines, or diagonals.
- **Input Validation:** Robust validation ensures players enter valid amounts and choices.
- **Randomized Gameplay:** Each spin generates a new, random 3x3 grid, ensuring unpredictability.
- **User-Friendly Interface:** Clear prompts and messages guide players throughout the game.
- **Flexible Gameplay:** Players can change their play option or quit the game after each spin.

## How to Play

1. **Starting the Game:**
   - Run the program.
   - Enter the amount you'd like to start with (between €1 and €100).

2. **Choosing Play Option:**
   - Select your preferred game mode from the following:
     - **1:** Center Line
     - **2:** All Horizontal Lines
     - **3:** All Vertical Lines
     - **4:** Diagonals
     - **5:** Quit Game

3. **Playing the Game:**
   - Each spin costs €1.
   - After each spin, the 3x3 grid is displayed.
   - If you win based on your chosen play option, your winnings are added to your balance.
   - You can choose to spin again or change your play option.

4. **Ending the Game:**
   - The game ends when you run out of money or choose to quit.

## Function Breakdown

- `Main()`: Controls the main game loop and flow.
- `GenerateRandomGrid()`: Creates a 3x3 grid with random values.
- `CheckWinCondition()`: Verifies if the player has won based on the chosen play option.
- `DeductSpinCost()`: Removes the spin cost from the player's balance.
- `SelectPlayOption()`: Allows the player to choose a play option.
- `DisplayGrid()`: Shows the current grid state to the player.
- `GetStartingMoney()`: Prompts the player for their starting balance.
- `ShouldContinueSpinning()`: Asks if the player wants to spin again or change options.

## Getting Started

1. **Prerequisites:**
   * Ensure you have a C# compiler or an environment like Visual Studio.

2. **Running the Game:**
   * Clone the repository.
   * Open the project in your preferred C# environment.
   * Build and run the project.

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create your feature branch: `git checkout -b feature/YourFeature`
3. Commit your changes: `git commit -m 'Add YourFeature'`
4. Push to the branch: `git push origin feature/YourFeature`
5. Open a pull request.

## License

This project is licensed under the MIT License.
```


1. Ensure you have .NET Core SDK installed on your machine.
2. Clone this repository or download the source code.
3. Open a terminal/command prompt and navigate to the project directory.
4. Run the following command:
