using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            // Явно расставляем скобки, чтобы подчеркнуть приоритет && над ||
            bool part1 = a && !b;      // true && true → true
            bool part2 = b && !a;      // false && false → false
            bool res = part1 || part2; // true || false → true

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"(a && !b) = {part1}");
            Console.WriteLine($"(b && !a) = {part2}");
            Console.WriteLine($"((a && !b) || (b && !a)) = {res}"); // True
        }
    }
}

