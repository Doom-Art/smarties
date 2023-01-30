namespace smarties
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    time += (16 * red);
                    if (orange != 0)
                        time += ((orange / 7) + 1) * 13;
                    if (blue != 0)
                        time += ((blue / 7) + 1) * 13;
                    if (green != 0)
                        time += ((green / 7) + 1) * 13;
                    if (yellow != 0)
                        time += ((yellow / 7) + 1) * 13;
                    if (pink != 0)
                        time += ((pink / 7) + 1) * 13;
                    if (violet != 0)
                        time += ((violet/ 7) + 1) * 13;
                    if (brown != 0)
                        time += ((brown/ 7) + 1) * 13;
                    Console.WriteLine(time);
                    Console.WriteLine(red);
                    Console.WriteLine(blue);
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