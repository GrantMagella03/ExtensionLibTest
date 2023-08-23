using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtLibTest {
    internal static class mathExtLib {
        public static int Func1(int x) {
            return (x * x) + (3 * x) + (5);
        }
        public static void WriteLn(this int s, string Prefix = "", string Suffix = "") {
            Console.WriteLine($"{Prefix}{s}{Suffix}");
        }
    }
}
