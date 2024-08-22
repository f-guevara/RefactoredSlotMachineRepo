namespace SlotMachine
{
    internal static class SlotMachineGame
    {
        // Constants for the grid size and random value range
        public const int GRID_SIZE = 3;
        public const int RANDOM_MIN_VALUE = 0;
        public const int RANDOM_MAX_VALUE = 6;

        // Constants related to money
        public const int MIN_BET_AMOUNT = 1;
        public const int MAX_BET_AMOUNT = 100;
        public const int COST_PER_SPIN = 1;
        public const int WIN_AMOUNT = 10;

        public static int[,] GenerateRandomGrid()
        {
            int[,] grid = new int[GRID_SIZE, GRID_SIZE];
            Random random = new Random();

            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    grid[i, j] = random.Next(RANDOM_MIN_VALUE, RANDOM_MAX_VALUE);
                }
            }

            return grid;
        }

        // Method to deduct the cost of a spin
        public static int DeductSpinCost(int currentMoney)
        {
            return currentMoney - COST_PER_SPIN;
        }

        public static bool CheckWinCondition(int[,] grid)
        {
            // Check if all numbers in the middle row are the same
            int middleRowValue = grid[1, 0];
            for (int j = 1; j < GRID_SIZE; j++)
            {
                if (grid[1, j] != middleRowValue)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
