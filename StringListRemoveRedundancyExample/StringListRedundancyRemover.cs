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

        public static List<string> RemoveRedundancy2(List<string> words)
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

        public static IEnumerable<string> RemoveRedundancy3(List<string> words)
        {
            foreach (var word in new HashSet<string>(words))
            {
                yield return word;
            }
        }
        public static IEnumerable<string> RemoveRedundancy4(List<string> words)
        {
            var trackingWords = new List<string>();

            foreach (var word in words)
            {
                foreach (var trackingWord in trackingWords)
                {
                    if(word.Equals(trackingWord))
                        goto OUTERCONTINUE;
                }

                trackingWords.Add(word);
                yield return word;

                OUTERCONTINUE:
                ;
            }
        }
    }
}
