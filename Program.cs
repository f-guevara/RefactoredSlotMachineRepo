namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate and display the random grid
            int[,] grid = SlotMachineGame.GenerateRandomGrid();
            ConsoleUI.DisplayGrid(grid);

            // Wait for user input before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

