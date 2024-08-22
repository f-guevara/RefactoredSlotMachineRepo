namespace SlotMachine
{
    internal static class SlotMachineGame
    {
        // Constants for the grid size and random value range
        public const int GRID_SIZE = 3;
        public const int RANDOM_MIN_VALUE = 0;
        public const int RANDOM_MAX_VALUE = 6;

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
    }
}
