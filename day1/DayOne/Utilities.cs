public class Utilities
{
    private static string fileName = "numbers.txt";

    internal static int LoadLists(List<int> numbers)
    {
        try
        {
            int totalDistances = 0;
            if (File.Exists(fileName))
            {
                numbers.Clear();

                List<int> firstList = new List<int>();
                List<int> secondList = new List<int>();

                char[] delimiterChars = { ' ', '\n', '\t', '\r' };
                var numbersSplit = File.ReadAllLines(fileName).Select(line => line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries)).ToList();


                foreach (var nums in numbersSplit)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            firstList.Add(Int32.Parse(nums[i]));
                        }
                        else
                        {
                            secondList.Add(Int32.Parse(nums[i]));
                        }
                    }
                }

                List<int> firstListSorted = firstList.OrderBy(n => n).ToList();

                List<int> secondListSorted = secondList.OrderBy(n => n).ToList();


                for (int i = 0; i < firstListSorted.Count; i++)
                {
                    int first = firstListSorted[i];
                    int second = secondListSorted[i];
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
            }
            return totalDistances;
        }
        catch (IndexOutOfRangeException eor)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Tried to select an index that doesn't exist");
            Console.WriteLine(eor);
            return 0;
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(e);
            return 0;
        }
    }

}
