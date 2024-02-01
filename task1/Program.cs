// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        // Define horse strokes
        int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

        
        int x = 3; // for example
        int y = 3; // for example

       
        for (int i = 0; i < 8; i++)
        {
            int newX = x + dx[i];
            int newY = y + dy[i];

            if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
            {
                matrix[newX, newY] = 1; // 1 can represent the visited position of the horse
            }
        }

        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
