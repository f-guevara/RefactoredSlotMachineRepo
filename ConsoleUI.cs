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
    }
}
