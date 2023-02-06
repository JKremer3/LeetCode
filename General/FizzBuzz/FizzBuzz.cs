using System;
using System.Collections.Generic;
using System.Collections;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var divTerms = new Dictionary<int, String>();
            String numPhrase = null;
            divTerms.Add(3, "Fizz");
            divTerms.Add(5, "Buzz");
            divTerms.Add(7, "Zazz");
            
            for (int i = 1; i <= 130; i++)
            {
                foreach (int term in divTerms.Keys)
                {
                    if (i % term == 0)
                    {
                        numPhrase += divTerms[term];
                    }
                }

                if (numPhrase == null)
                    numPhrase = i.ToString();
                
                System.Console.WriteLine(numPhrase);
                numPhrase = null;
            }

        }
    }
}

