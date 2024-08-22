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

        // New constants for play options
        public const int PLAY_OPTION_CENTER_LINE = 1;
        public const int PLAY_OPTION_HORIZONTAL_LINES = 2;
        public const int PLAY_OPTION_VERTICAL_LINES = 3;
        public const int PLAY_OPTION_DIAGONALS = 4;
        public const int PLAY_OPTION_QUIT = 5;

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

        public static bool CheckWinCondition(int[,] grid, int playOption)
        {
            switch (playOption)
            {
                case PLAY_OPTION_CENTER_LINE:
                    return CheckCenterLine(grid);
                case PLAY_OPTION_HORIZONTAL_LINES:
                    return CheckHorizontalLines(grid);
                case PLAY_OPTION_VERTICAL_LINES:
                    return CheckVerticalLines(grid);
                case PLAY_OPTION_DIAGONALS:
                    return CheckDiagonals(grid);
                default:
                    return false;
            }
        }

        private static bool CheckCenterLine(int[,] grid)
        {
            int centerValue = grid[1, 0];
            for (int j = 1; j < GRID_SIZE; j++)
            {
                if (grid[1, j] != centerValue)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckHorizontalLines(int[,] grid)
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                int rowValue = grid[i, 0];
                bool rowMatch = true;
                for (int j = 1; j < GRID_SIZE; j++)
                {
                    if (grid[i, j] != rowValue)
                    {
                        rowMatch = false;
                        break;
                    }
                }
                if (rowMatch) return true;
            }
            return false;
        }

        private static bool CheckVerticalLines(int[,] grid)
        {
            for (int j = 0; j < GRID_SIZE; j++)
            {
                int colValue = grid[0, j];
                bool colMatch = true;
                for (int i = 1; i < GRID_SIZE; i++)
                {
                    if (grid[i, j] != colValue)
                    {
                        colMatch = false;
                        break;
                    }
                }
                if (colMatch) return true;
            }
            return false;
        }

        private static bool CheckDiagonals(int[,] grid)
        {
            // Check main diagonal
            int mainDiagValue = grid[0, 0];
            bool mainDiagMatch = true;
            for (int i = 1; i < GRID_SIZE; i++)
            {
                if (grid[i, i] != mainDiagValue)
                {
                    mainDiagMatch = false;
                    break;
                }
            }
            if (mainDiagMatch) return true;

            // Check anti-diagonal
            int antiDiagValue = grid[0, GRID_SIZE - 1];
            bool antiDiagMatch = true;
            for (int i = 1; i < GRID_SIZE; i++)
            {
                if (grid[i, GRID_SIZE - 1 - i] != antiDiagValue)
                {
                    antiDiagMatch = false;
                    break;
                }
            }
            return antiDiagMatch;
        }
    }
}
