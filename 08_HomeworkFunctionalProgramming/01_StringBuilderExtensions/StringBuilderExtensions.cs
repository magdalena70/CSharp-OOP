using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensions
{
    // create static class for extension methods
    public static class StringBuilderExtensions
    {

        // Implement the following extension methods for the class StringBuilder:

        // Substring(int startIndex, int length) – 
        // returns a new String object, containing the elements in the given range. 
        // Throw an exception when the range is invalid.
        public static string Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            string strAsString = strBuilder.ToString();
            string substring = strAsString.Substring(startIndex, length);
            return substring;
        }

        // RemoveText(string text) – 
        // removes all occurrences of the specified text (case-insensitive) from the StringBuilder. 
        // The method should not create a new StringBuilder, but should modify the existing one and return it as a result.
        public static StringBuilder RemoveText(this StringBuilder strBuilder, string text)
        {
            var strAsString = strBuilder.ToString();
            while (true)
            {
                var textPosition = strAsString.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);
                if (textPosition < 0)
                {
                    break;
                }

                var textLenght = text.Length;
                strAsString = strAsString.Remove(textPosition, textLenght);
            }

            return strBuilder =  new StringBuilder(strAsString);
        }

        // AppendAll<T>(IEnumerable<T> items) – 
        // appends the string representations of all items from the specified collection. 
        // Use ToString() to convert from T to string.
        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder, IEnumerable<T> items)
        {
            var resultString = items.Aggregate("", (current, item) => current + item.ToString());
            return strBuilder.Append(resultString);
        }
    }
}
