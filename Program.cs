namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for the starting amount of money with validation
            int money = ConsoleUI.GetStartingMoney();

            while (money >= SlotMachineGame.COST_PER_SPIN)
            {
                //Select play option or quit the game
                int currentOption = ConsoleUI.SelectPlayOption();
                if (currentOption == SlotMachineGame.PLAY_OPTION_QUIT)
                {
                    break;
                }

                Console.WriteLine($"You've selected option {currentOption}");


                bool continuePlaying = true;

                while (continuePlaying && money >= SlotMachineGame.COST_PER_SPIN)
                {
                    money = SlotMachineGame.DeductSpinCost(money);
                    int[,] grid = SlotMachineGame.GenerateRandomGrid();
                    ConsoleUI.DisplayGrid(grid);

                    if (SlotMachineGame.CheckWinCondition(grid, currentOption))
                    {
                        money += SlotMachineGame.WIN_AMOUNT;
                        ConsoleUI.DisplayWinMessage(SlotMachineGame.WIN_AMOUNT);
                    }

                    ConsoleUI.DisplayRemainingMoney(money);

                    if (money < SlotMachineGame.COST_PER_SPIN)
                    {
                        ConsoleUI.DisplayInsufficientFundsMessage();
                        break;
                    }

                    continuePlaying = ConsoleUI.ShouldContinueSpinning();
                }

                if (money < SlotMachineGame.COST_PER_SPIN)
                {
                    break;
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

