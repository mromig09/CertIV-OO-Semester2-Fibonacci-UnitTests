using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessor
{
    public class Processor
    {
        /// <summary>
        /// Returns number of char found in word.  Case-insensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int CountChar(string word, char c)
        {
            int count = 0;
            foreach (char t in word)
            {
                if (char.ToLower(c) == char.ToLower(t))
                {
                    count++;
                }              
            }
            return count;
        }
            
        
        /// <summary>
        /// Returns word in reverse.  Case sensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string Reverse(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Replaces all spaces in a word with char.  Case sensitive.  Replaces pre and trailing spaces
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string ReplaceSpace(string word, char c)
        {
           return word.Replace(' ', c);
        }
    }
}
