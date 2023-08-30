using System;

namespace Point_Counter
{
    internal class Program
    {
        class Point
        {
            private int x, y;

            // Parametrized Constructor
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Auto Property for X and Y

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            // Print
            public void ShowData()
            {
                Console.WriteLine($"X: {x}, Y: {y}");
            }
        }



        class Counter
        {
            private int min, max, current;

            // Parametrized Constructor
            public Counter(int min, int max)
            {
                this.min = min;
                this.max = max;
                current = min;
            }

            // Default Constructor
            public Counter() : this(0, 100)
            {

            }

            public void Increment()
            {
                current++;
                if (current > max)
                {
                    current = min;
                }
            }

            public int GetCurrent()
            {
                return current;
            }
        }


        static void Main(string[] args)
        {
            Counter c = new Counter();

            c.Increment();
            Console.WriteLine(c.GetCurrent()); // 1

            c.Increment();
            Console.WriteLine(c.GetCurrent()); // 2
        }
    }
}