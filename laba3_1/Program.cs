using System.Text;
using System.Diagnostics;
using System.Collections;

namespace laba4
{
    internal static class Program
    {
        public static string SeachInList(string searchableWord, string[] words)
        {
            foreach (string word in words)
            {
                if (word == searchableWord)
                {
                    return word;
                }
            }
            return null;
        }

        public static string SeachInTreeSet(string searchableWord, SortedSet<string> words)
        {
            foreach (string word in words)
            {
                if (word == searchableWord)
                {
                    return word;
                }
            }
            return null;
        }

        public static string SeachInHashSet(string searchableWord, HashSet<string> words)
        {
            foreach (string word in words)
            {
                if (word == searchableWord)
                {
                    return word;
                }
            }
            return null;
        }
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Stopwatch timer = new Stopwatch();
            string[] words = {"Ukraine", "is", "a", "country", "in", "Eastern", "Europe" };

            //LinkedList
            LinkedList<string> sentence = new LinkedList<string>(words);
            Console.WriteLine("LinkedList:");
            
            timer.Start();
            sentence.AddFirst("today");
            timer.Stop();
            Console.WriteLine("Час додавання: {0}", timer.Elapsed);
            timer.Restart();
            
            timer.Start();
            var result = sentence.Find("country");
            timer.Stop();
            Console.WriteLine("Час пошуку: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            sentence.Remove("country");
            timer.Stop();
            Console.WriteLine("Час видалення: {0}", timer.Elapsed);


            //ArrayList
            ArrayList sentence1 = new ArrayList(words);
            Console.WriteLine("ArrayList");
            //PrintValues(sentence1);
            timer.Start();
            sentence1.Add("today");
            timer.Stop();
            Console.WriteLine("Час додавання: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            string result1 = SeachInList("country", words);
            timer.Stop();
            Console.WriteLine("Час пошуку: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            sentence1.Remove("country");
            timer.Stop();
            Console.WriteLine("Час видалення: {0}", timer.Elapsed);

            //TreeSet
            SortedSet<string> sentence2 = new SortedSet<string>(words);
            Console.WriteLine("TreeSet:");
            timer.Start();
            sentence2.Add("today");
            timer.Stop();
            Console.WriteLine("Час додавання: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            string result2 = SeachInTreeSet("country", sentence2);
            timer.Stop();
            Console.WriteLine("Час пошуку: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            sentence2.Remove("country");
            timer.Stop();
            Console.WriteLine("Час видалення: {0}", timer.Elapsed);

            //HashSet
            HashSet<string> sentence3 = new HashSet<string>(words);
            Console.WriteLine("HashSet:");
            timer.Start();
            sentence2.Add("today");
            timer.Stop();
            Console.WriteLine("Час додавання: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            string result3 = SeachInHashSet("country", sentence3);
            timer.Stop();
            Console.WriteLine("Час пошуку: {0}", timer.Elapsed);
            timer.Restart();

            timer.Start();
            sentence2.Remove("country");
            timer.Stop();
            Console.WriteLine("Час видалення: {0}", timer.Elapsed);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
