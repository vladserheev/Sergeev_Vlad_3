using System.Text;
using System.Collections.Generic;


namespace laba3_2
{
    internal static class Program
    {
        public static bool checkUniqueValue(string value, List<string> uniqueValues)
        {
            foreach (string uniqueValue in uniqueValues)
            {
                if (value == uniqueValue)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {0,"soo1"},
                {1,"soo2"},
                {2,"soo1"},
                {3,"soo5"},
                {4,"soo5"},
                {5,"soo9"},
                {6,"soo7"}
            };
            List<string> uniqueValues = new List<string>();
            Console.WriteLine("Початковий словник:");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            foreach (var item in dic)
            {
                if (checkUniqueValue(item.Value, uniqueValues))
                {
                    uniqueValues.Add(item.Value);
                }
            }


            Console.WriteLine("Унікальні значення: " + String.Join(",", uniqueValues));
        }
    }
}
