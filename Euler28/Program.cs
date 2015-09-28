using System;

namespace Euler28
{
    class Program
    {
        enum Direction { DOWN, LEFT, UP, RIGHT };

        static void Main(string[] args)
        {
            int SIZE = 1001;
            
            int[,] grid = new int[SIZE, SIZE];

            int center = (SIZE - 1) / 2;

            grid[center, center] = 1;
            int n = 2;
            int row = center;
            int col = center + 1;
            Direction d = Direction.DOWN;

            while (!(row == 0 && col == SIZE - 1))
            {
                grid[row, col] = n;
                n++;
                if(d == Direction.DOWN)
                {
                    if(grid[row + 1, col - 1] == 0)
                        d = Direction.LEFT;

                    row++;
                    continue;
                }

                if (d == Direction.LEFT)
                {
                    if (grid[row -1, col - 1] == 0)
                        d = Direction.UP;

                    col--;
                    continue;
                }

                if (d == Direction.UP)
                {
                    if (grid[row - 1, col + 1] == 0)
                        d = Direction.RIGHT;

                    row--;
                    continue;
                }

                if (d == Direction.RIGHT)
                {
                    if (grid[row + 1, col + 1] == 0)
                        d = Direction.DOWN;

                    col++;
                    continue;
                }
            }
            grid[row, col] = SIZE * SIZE;

            int sum = 0;
            int i = 0;

            while (i < SIZE)
            {
                sum += grid[i, i];
                sum += grid[i, SIZE - i - 1];
                i++;
            }

            //substract center value to avoid double count
            sum -= grid[center, center];

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
