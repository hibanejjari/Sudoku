
using System;

namespace Sudoku
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sudoku Game Started");
            Console.ResetColor();
            Console.WriteLine();
            Game game = new Game();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Enter row, column, and value (separated by spaces), or 'q' to quit:");
                Console.ResetColor();
                string input = Console.ReadLine();
                if (input?.ToLower() == "q")
                {
                    break;
                }

                string[] parts = input.Split(' ');
                if (parts.Length == 3 && int.TryParse(parts[0], out int row) && int.TryParse(parts[1], out int col) && int.TryParse(parts[2], out int value))
                {
                    game.SetCellValue(row, col, value);
                    Console.WriteLine();
                    DisplayGrid(game);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter row, column, and value separated by spaces.");
                }
            }

            Console.WriteLine("Thank you for playing Sudoku!");
        }

        static void DisplayGrid(Game game)
        {
            Console.WriteLine(); // Add a space before displaying the grid

            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0 && row != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("------+-------+------------+-------");
                    Console.ResetColor();
                }

                for (int col = 0; col < 9; col++)
                {
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("|");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    int cellValue = game.GetCellValue(row, col);
                    if (cellValue == 0) // Assuming 0 represents an empty cell
                    {
                        Console.Write(" . ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan; // Set number color
                        Console.Write($" {cellValue} ");
                        Console.ResetColor(); // Reset to default color
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // Add a space after displaying the grid

            
        }
    }
}



