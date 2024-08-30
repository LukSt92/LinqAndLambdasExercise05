using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing001
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in SimpleEnumerable()) Console.WriteLine(s);
        }
        static IEnumerable<string> SimpleEnumerable()
        {
            yield return "apples";
            yield return "oranges";
            yield return "bananas";
            yield return "unicorns";
        }
    }
}
