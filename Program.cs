namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Ask for the starting amount of money with validation
            int money = ConsoleUI.GetStartingMoney();

            while (money >= SlotMachineGame.COST_PER_SPIN)
            {
                // Step 3: Deduct the cost per spin and display the grid
                money = SlotMachineGame.DeductSpinCost(money);
                int[,] grid = SlotMachineGame.GenerateRandomGrid();
                ConsoleUI.DisplayGrid(grid);

                // Display remaining money
                ConsoleUI.DisplayRemainingMoney(money);

                // Check if player can continue
                if (money < SlotMachineGame.COST_PER_SPIN)
                {
                    ConsoleUI.DisplayInsufficientFundsMessage();
                    break;
                }

                Console.WriteLine("Press any key to spin again...");
                Console.ReadKey(true);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

