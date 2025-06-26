namespace AdventOfCode2024.Day2;

public class Solution
{
    internal static List<List<int>> Extract(string file)
    {
        List<List<int>> records = new List<List<int>>();
        if (File.Exists(file))
        {
            var splitLines = File.ReadLines(file).Select(line => line.Split("\n"));

            foreach (var line in splitLines)
            {
                Console.WriteLine(line);
                List<int> record = new List<int>();
                for (int i = 0; i < line.Length; i++)
                {
                    var chars = line[i].Split(" ");
                    // foreach (var c in chars)
                    // {
                    //     record.Add(Int32.Parse(c));
                    // }
                    Console.WriteLine(record);
                    records.Add(record);
                }
                record.TrimExcess();
                record.Clear();
            }
        }

        return records;
    }


    public static void Main(string[] args)
    {
        string filePath = "/home/void/workspace/github.com/ririthewizard/aoc2024-csharp/DayTwo/reports.txt";
        Extract(filePath);
    }
}

