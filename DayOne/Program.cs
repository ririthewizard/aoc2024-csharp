namespace AdventOfCode2024.Day1;

public class Solution
{
    internal static (List<int> listOne, List<int> listTwo) Sort(string file)
    {
        List<int> firstListSorted = [];
        List<int> secondListSorted = [];
        try
        {
            if (File.Exists(file))
            {
                List<int> firstList = [];
                List<int> secondList = [];

                char[] delimiterChars = { ' ', '\n', '\t', '\r' };
                var numbersSplit = File.ReadAllLines(file).Select(line => line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries)).ToList();


                foreach (var nums in numbersSplit)
                {
                    firstList.Add(Int32.Parse(nums[0]));
                    secondList.Add(Int32.Parse(nums[1]));
                }

                firstListSorted = firstList.OrderBy(n => n).ToList();

                secondListSorted = secondList.OrderBy(n => n).ToList();

            }
            return (firstListSorted, secondListSorted);
        }

        catch (IndexOutOfRangeException eor)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Tried to select an index that doesn't exist");
            Console.WriteLine(eor);
            return (new List<int>(), new List<int>());

        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(e);
            return (new List<int>(), new List<int>());
        }
    }

    internal static int PartOne(List<int> listOne, List<int> listTwo)
    {

        int totalDistances = 0;
        for (int i = 0; i < listOne.Count; i++)
        {
            int first = listOne[i];
            int second = listTwo[i];
            if (first > second)
            {
                totalDistances += (first - second);
            }
            else
            {
                totalDistances += (second - first);
            }
        }

        Console.WriteLine(totalDistances);
        return totalDistances;
    }

    internal static int PartTwo(List<int> listOne, List<int> listTwo)
    {
        int similarity = 0;

        foreach (var num in listOne)
        {
            similarity += (num * listTwo.Count(n => n == num));
        }
        Console.WriteLine(similarity);
        return similarity;
    }

    public static void Main(string[] args)
    {
        string inputFile = "/home/void/workspace/github.com/ririthewizard/aoc2024-csharp/day1/DayOne/numbers.txt";
        var sorted = Sort(inputFile);
        (var listOne, var listTwo) = sorted;
        PartOne(listOne, listTwo);
        PartTwo(listOne, listTwo);
    }

}
