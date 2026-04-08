using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CalculateBytes
    {
        public static void ByteCalculation()
        {
            Console.WriteLine($"{"Type",-10} {"Bytes",-5} {"Min",-35} {"Max",-35}");
            Console.WriteLine(new string('-', 90));

            Console.WriteLine($"{"sbyte",-10} {sizeof(sbyte),-5} {sbyte.MinValue,-35} {sbyte.MaxValue,-35}");
            Console.WriteLine($"{"byte",-10} {sizeof(byte),-5} {byte.MinValue,-35} {byte.MaxValue,-35}");
            Console.WriteLine($"{"short",-10} {sizeof(short),-5} {short.MinValue,-35} {short.MaxValue,-35}");
            Console.WriteLine($"{"ushort",-10} {sizeof(ushort),-5} {ushort.MinValue,-35} {ushort.MaxValue,-35}");
            Console.WriteLine($"{"int",-10} {sizeof(int),-5} {int.MinValue,-35} {int.MaxValue,-35}");
            Console.WriteLine($"{"uint",-10} {sizeof(uint),-5} {uint.MinValue,-35} {uint.MaxValue,-35}");
            Console.WriteLine($"{"long",-10} {sizeof(long),-5} {long.MinValue,-35} {long.MaxValue,-35}");
            Console.WriteLine($"{"ulong",-10} {sizeof(ulong),-5} {ulong.MinValue,-35} {ulong.MaxValue,-35}");
            Console.WriteLine($"{"float",-10} {sizeof(float),-5} {float.MinValue,-35} {float.MaxValue,-35}");
            Console.WriteLine($"{"double",-10} {sizeof(double),-5} {double.MinValue,-35} {double.MaxValue,-35}");
            Console.WriteLine($"{"decimal",-10} {sizeof(decimal),-5} {decimal.MinValue,-35} {decimal.MaxValue,-35}");

        }
    }
}
