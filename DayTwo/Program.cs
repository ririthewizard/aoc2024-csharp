namespace AdventOfCode2024.Day2;

public class Solution
{
    internal static List<int> SafeOrUnsafe(string file)
    {
        List<int> reports = new List<int>();
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] report = line.Split(' ', '\n');
                for (int i = 0; i < report.Length; i++)
                {
                    int sign;
                }
            }
        }

        return reports;
    }


    public static void Main(string[] args)
    {
        string filePath = "/home/void/workspace/github.com/ririthewizard/aoc2024-csharp/DayTwo/reports.txt";
        SafeOrUnsafe(filePath);
    }
}

