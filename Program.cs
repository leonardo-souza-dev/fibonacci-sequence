using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> myList = new List<BigInteger>();

            BigInteger j = 0;
            myList.Add(j);

            BigInteger temp = 0;
            int counter = 0;

            for (BigInteger i = 1; counter < 100; i = j + temp)
            {
                temp = j;
                myList.Add(i);
                j = i;
                counter++;
            }

            Console.WriteLine(string.Join(", ", myList));
            Console.ReadKey();
        }
    }
}
