using System.Collections.Generic;
using System.Linq;

namespace ModerateMathLC
{
    //Problem Constraints : 1 <= NUM <= 3999
    public static class IntToNumeral
    {
        public static string IntToRomanIterative(int num)
        {
            // initialize list of numerals, 
            var numeralList = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("M", 1000),
                new KeyValuePair<string, int>("CM", 900),
                new KeyValuePair<string, int>("D", 500),
                new KeyValuePair<string, int>("CD", 400),
                new KeyValuePair<string, int>("C", 100),
                new KeyValuePair<string, int>("XC", 90),
                new KeyValuePair<string, int>("L", 50),
                new KeyValuePair<string, int>("XL", 40),
                new KeyValuePair<string, int>("X", 10),
                new KeyValuePair<string, int>("IX", 9),
                new KeyValuePair<string, int>("V", 5),
                new KeyValuePair<string, int>("IV", 4),
                new KeyValuePair<string, int>("I", 1)
            };
            string retString = "";

            foreach (KeyValuePair<string,int> numeralPair in numeralList)
            {
                int numeralCount = num / numeralPair.Value;
                
                if (numeralCount != 0)
                {
                    retString += string.Concat(Enumerable.Repeat(numeralPair.Key, numeralCount));
                }

                num -= numeralPair.Value * numeralCount;
            }
            
            return retString;
        }
    }
}