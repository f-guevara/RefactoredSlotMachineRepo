namespace SlotMachine
{
    internal static class ConsoleUI
    {
        public static void DisplayGrid(int[,] grid)
        {
            for (int i = 0; i < SlotMachineGame.GRID_SIZE; i++)
            {
                for (int j = 0; j < SlotMachineGame.GRID_SIZE; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int GetStartingMoney()
        {
            int money = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Enter the amount of money you want to start with ({SlotMachineGame.MIN_BET_AMOUNT} to {SlotMachineGame.MAX_BET_AMOUNT} euros): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out money))
                {
                    if (money >= SlotMachineGame.MIN_BET_AMOUNT && money <= SlotMachineGame.MAX_BET_AMOUNT)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter an amount between {SlotMachineGame.MIN_BET_AMOUNT} and {SlotMachineGame.MAX_BET_AMOUNT} euros.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number (no cents).");
                }
            }

            return money;
        }

        public static void DisplayRemainingMoney(int money)
        {
            Console.WriteLine($"You have {money} euros left.");
        }

        public static void DisplayInsufficientFundsMessage()
        {
            Console.WriteLine("You don't have enough money to spin. Game Over.");
        }

        public static void DisplayWinMessage(int winAmount)
        {
            Console.WriteLine($"Congratulations! You won {winAmount} euros!");
        }

        public static int SelectPlayOption()
        {
            while (true)
            {
                Console.WriteLine("\nChoose your play option:");
                Console.WriteLine($"{SlotMachineGame.PLAY_OPTION_CENTER_LINE}: Center Line");
                Console.WriteLine($"{SlotMachineGame.PLAY_OPTION_HORIZONTAL_LINES}: Horizontal Lines");
                Console.WriteLine($"{SlotMachineGame.PLAY_OPTION_VERTICAL_LINES}: Vertical Lines");
                Console.WriteLine($"{SlotMachineGame.PLAY_OPTION_DIAGONALS}: Diagonals");
                Console.WriteLine($"{SlotMachineGame.PLAY_OPTION_QUIT}: Quit Game");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= SlotMachineGame.PLAY_OPTION_CENTER_LINE && choice <= SlotMachineGame.PLAY_OPTION_QUIT)
                    {
                        return choice;
                    }
                }
                Console.WriteLine("Invalid option. Please try again.");
            }
        }

        public static bool ShouldContinueSpinning()
        {
            Console.WriteLine("Press any key to spin again, or ESC to change play option...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
            return keyInfo.Key != ConsoleKey.Escape;
        }

    }
}
