namespace AdventOfCode2024.Day2;

public class Solution
{
    internal static List<List<int>> Extract(string file)
    {
        List<List<int>> records = new List<List<int>>();
        if (File.Exists(file))
        {
            var splitLines = File.ReadAllLines(file).Select(line => line.Split("\n"));

            foreach (var line in splitLines)
            {

            }
        }

        return records;
    }
}
