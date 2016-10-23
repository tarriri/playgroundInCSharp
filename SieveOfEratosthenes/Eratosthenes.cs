using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",",FindPrimesBySieve(20000)));
        }

        public static List<int> FindPrimesBySieve(int n)
        {
            bool[] isPrime = new bool[n+1];
            for (int i = 0; i < n; i++)
                isPrime[i] = true;
            for (int i = 2; i*i < n; i++)
                if(isPrime[i])
                    for (int j = i*i; j < n; j+=i)
                        isPrime[j] = false;
            List<int> result = new List<int>();
            for (int i = 2; i < n; i++)
                if(isPrime[i])
                    result.Add(i);
            return result;
        }
    }
}
