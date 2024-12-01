/*
 * Solution for the Day1 problem on Advent of Code
 * 
 * See: https://adventofcode.com/2024/day/1
 */
namespace AdventOfCode
{
    internal class Day1
    {
        public static void Main(string[] args)
        {
            const string delimeter = "   "; 
            List<string> inputStrings = [.. File.ReadAllLines("C:\\Users\\Kane\\source\\repos\\AoC2024\\AoC2024\\data\\day1_input.txt")];
            List<int> listA = [];
            List<int> listB = [];

            inputStrings.ForEach(line => {
                string[] lines = line.Split(delimeter);
                listA.Add(int.Parse(lines[0]));
                listB.Add(int.Parse(lines[1]));
            });

            listA.Sort();
            listB.Sort();

            int totalDifference = 0;
            for (int i = 0; i < inputStrings.Count; i++)
            {
                totalDifference += Math.Abs(listA[i] - listB[i]);
            }

            Console.WriteLine($"Total difference: {totalDifference}");


            //Part 2:
            int totalSim  = listA.Sum(value => value * listB.Count(x => x == value));
            Console.WriteLine($"Total similarity score: {totalSim}");
        }
    }
}
