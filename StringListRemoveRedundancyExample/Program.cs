using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringListRemoveRedundancyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() {"one", "two", "three", "two", "four", "three"};

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            var uniqueWords1 = StringListRedundancyRemover.RemoveRedundancy1(words);

            foreach (var uniqueWord in uniqueWords1)
            {
                Console.WriteLine(uniqueWord);
            }

            Console.WriteLine();

            var uniqueWords2 = StringListRedundancyRemover.RemoveRedendancy2(words);

            foreach (var uniqueWord in uniqueWords2)
            {
                Console.WriteLine(uniqueWord);
            }

            Console.WriteLine();

            var uniqueWords3 = words.Distinct().ToList();

            foreach (var uniqueWord in uniqueWords3)
            {
                Console.WriteLine(uniqueWord);
            }
        }
    }
}
