using System;

namespace Exercice2
{
    public struct Celsius
    {
        public double Temperature;
    }
    public struct Fahrenheit
    {
        public double Temperature;
    }

    public struct Point
    {
        public int X;
        public int Y;

        public string toString()
        {
            return $"X : {X} - Y : {Y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point?[,] points = new Point?[5,5];
            for(int i = 0;i < points.GetLength(0);i++ )
            {
                points[i, i] = new Point { X = i + 1, Y = i + 1 };
            }

            for (int y = 0; y < points.GetLength(0); y++)
            {
                for (int x = 0; x < points.GetLength(1); x++)
                {
                    Console.Write(points[y, x] is Point p ? p.toString() : "    ");
                }
                Console.Write("\n");
            }
        }
    }
}
