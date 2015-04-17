using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArrayTest
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(62);

            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            BitArray64 number2 = new BitArray64(100);

            Console.WriteLine(number.Equals(number2));

            Console.WriteLine(number[2]);

            Console.WriteLine(number.GetHashCode());

            number[14] = 1;

            Console.WriteLine(number.Number);

            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
