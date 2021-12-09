namespace aoc2021
{
    public class Day1
    {
        public Day1()
        {
            var inp = File.ReadAllLines("./inputs/day-1/input");
            Console.WriteLine($"Day 1 | Part-1 Solution: {SolveOne(inp)}");
            Console.WriteLine($"Day 2 | Part-2 Solution: {SolveTwo(inp)}");
        }

        private int SolveOne(string[] input)
        {
            int increases = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0 && int.Parse(input[i]) > int.Parse(input[i - 1]))
                    increases++;
            }

            return increases;
        }
        private int SolveTwo(string[] input)
        {
            int increases = 0;
            int prevSum = 0;

            for (int i = 0; i < input.Length - 2; i++)
            {
                var sum = input.Take(new Range(i,i+3)).Select(x => int.Parse(x)).Sum();
                if(i != 0 && sum > prevSum){
                    increases++;
                    
                }
                prevSum = sum;
            }

            return increases;
        }
    }
}

