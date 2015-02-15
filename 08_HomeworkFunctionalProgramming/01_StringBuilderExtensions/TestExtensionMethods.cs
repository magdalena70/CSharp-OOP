using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensions
{
    class TestExtensionMethods
    {
        static void Main()
        {
            var test = new StringBuilder("StringBuilder Extensions");
            Console.WriteLine("string -> \"{0}\"", test);
            Console.WriteLine("test.Substring(3, 9) -> \"{0}\"", test.Substring(3, 9));
            Console.WriteLine("test.RemoveText(\"Exten\") -> \"{0}\"", test.RemoveText("Exten"));
            // test StringComparison.CurrentCultureIgnoreCase
            Console.WriteLine("test.RemoveText(\"stringbuilder\") -> \"{0}\"", test.RemoveText("stringbuilder"));
            Console.Write("test.AppendAll(string) -> \"");
            Console.WriteLine(test.AppendAll(
                new string[] {
                    ":\n",
                    " Substring(int startIndex, int length),\n",
                    " RemoveText(string text),\n",
                    " AppendAll<T>(IEnumerable<T> items).\"" }));
        }
    }
}
