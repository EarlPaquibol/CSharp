//Enumerate in phyton to C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerateTest {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> {4, 2, 3, 1, 8};
            foreach (var it in list.Select((Value, Index) => new {Value, Index})) {
                Console.WriteLine("{0}: {1}", it.Index, it.Value);
            }
            Console.ReadLine();
        }
    }
}
