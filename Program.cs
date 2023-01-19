namespace smarties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int orange = 0;
            int blue = 0;
            int green = 0;
            int yellow = 0;
            int pink = 0;
            int violet = 0;
            int brown = 0;
            int red = 0;
            int time = 0;

            foreach (string line in File.ReadLines("DATA10.txt"))
            {
                if (line == "orange")
                {
                    orange++;
                }
                else if (line == "blue")
                    blue++;
                else if (line == "green")
                    green++;
                else if (line == "yellow")
                    yellow++;
                else if (line == "pink")
                    pink++;
                else if (line == "violet")
                    violet++;
                else if (line == "brown")
                    brown++;
                else if (line == "red")
                    red++;
                else
                {
                    time += 16 * red;
                    time += ((orange / 7) + 1) * 13;

                    orange = 0;
                    blue = 0;
                    green = 0;
                    yellow = 0;
                    pink = 0;
                    violet = 0;
                    brown = 0;
                    red = 0;
                }

            }
        }
    }
}