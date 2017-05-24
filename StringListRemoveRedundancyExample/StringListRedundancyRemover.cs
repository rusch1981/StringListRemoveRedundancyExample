using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringListRemoveRedundancyExample
{
    class StringListRedundancyRemover
    {
        public static List<string> RemoveRedundancy1(List<string> words)
        {
            var uniqueWords = new List<string>();
            var isUnique = true;

            foreach(var word in words)
            {
                foreach(var uniqueWord in uniqueWords)
                {
                    if (word.Equals(uniqueWord))
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueWords.Add(word);
                }
                isUnique = true;
            }
            
            return uniqueWords;
        }

        public static List<string> RemoveRedendancy2(List<string> words)
        {
            var uniqueWords = new List<string>();
            var trackingWords = new List<string>();
            trackingWords.AddRange(words);

            words.ForEach(s =>
            {
                if (trackingWords.Contains(s))
                {
                    uniqueWords.Add(s);
                    trackingWords.RemoveAll(t => t.Equals(s));
                }
            });

            return uniqueWords;
        }
    }
}
