using System;
using System.Collections.Generic;
using System.Linq;

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

            var uniqueWords2 = StringListRedundancyRemover.RemoveRedundancy2(words);

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

            Console.WriteLine();

            var uniqueWords4 = new HashSet<string>(words);

            foreach (var uniqueWord in uniqueWords4)
                Console.WriteLine(uniqueWord);

            Console.WriteLine();

            foreach (var uniqueWord in StringListRedundancyRemover.RemoveRedundancy3(words))
            {
                Console.WriteLine(uniqueWord);
            }

            Console.WriteLine();

            foreach (var uniqueWord in StringListRedundancyRemover.RemoveRedundancy4(words))
            {
                Console.WriteLine(uniqueWord);
            }

            Console.WriteLine();
        }
    }
}
