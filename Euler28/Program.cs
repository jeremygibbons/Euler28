using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler28
{
    class Program
    {
        enum Direction { DOWN, LEFT, UP, RIGHT };

        static void Main(string[] args)
        {
            
            int[,] grid = new int[1001, 1001];

            Direction d = Direction.DOWN;

            grid[500, 500] = 1;
            int i = 2;
            int row = 500;
            int col = 501;

            while(!(row == 0 && col == 1000))
            {
                grid[row, col] = i;
                i++;
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
            grid[row, col] = 1001 * 1001;

            int sum = 0;

            int r = 0;
            int c = 0;

            while (r <= 1000)
            {
                sum += grid[r, c];
                r++;
                c++;
            }

            r = 0;
            c = 1000;

            while (r <= 1000)
            {
                sum += grid[r, c];
                r++;
                c--;
            }

            sum -= grid[500, 500];

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
