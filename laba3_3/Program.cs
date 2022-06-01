using System.Text;
using System.Linq;

namespace laba3_3
{
    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            string[] stringArray =
            {
                "Slava  Ukraini",
                "Heroyam Slava",
                "Ukraina",
                "ponad use!"
            };


            var evenLine = stringArray.Where(x => x.Length % 2 == 1).Select(x => x.First()).ToArray();
            var oddLine = stringArray.Where(x => x.Length % 2 == 0).Select(x => x.Last()).ToArray();

            var resultSting = evenLine.Concat(oddLine).ToArray();
            Console.WriteLine("До сортування:");
            Console.WriteLine(resultSting);

            Array.Sort(resultSting, StringComparer.Ordinal);
            Console.WriteLine("Після сортування:");
            Console.WriteLine(resultSting);
        }
    }
}
