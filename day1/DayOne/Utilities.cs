public class Utilities
{
    private static string fileName = "numbers.txt";

    internal static List<List<int>> LoadLists(List<int> numbers)
    {
        List<List<int>> loadedLists = new List<List<int>>();
        try
        {
            if (File.Exists(fileName))
            {
                numbers.Clear();

                List<int> firstList = new List<int>();
                List<int> secondList = new List<int>();

                //var numbersList = File.ReadAllLines(fileName)
                //.Select(line => line.Split(""));
                char[] delimiterChars = { ' ', '\n', '\t', '\r' };
                var numbersSplit = File.ReadAllLines(fileName).Select(line => line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries)).ToList();

                /*foreach (var nums in numbersSpaceSplit)
                {
                    foreach (var num in nums)
                    {
                        Console.WriteLine(num);
                    }
                }
                */

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




            }
            return loadedLists;
        }
        catch (IndexOutOfRangeException eor)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Tried to select an index that doesn't exist");
            Console.WriteLine(eor);
            return loadedLists;
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(e);
            return loadedLists;
        }
    }
}
