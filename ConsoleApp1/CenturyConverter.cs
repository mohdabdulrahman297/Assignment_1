using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    internal class CenturyConverter
    {
        public static void ConvertCenturies()
        {
            Console.Write("Enter centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            BigInteger years = centuries * 100;
            BigInteger days = years * 3652425 / 10000;
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
