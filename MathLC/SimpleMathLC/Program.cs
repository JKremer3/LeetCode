using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testArr = new int[2] {9,9};
            Console.WriteLine(PlusOne(testArr));
        }
        
        public static int[] TwoSum(int[] nums, int target) {
            var retArr = new int[2];

            for (int i = 0; i < nums.Length-1; i++)
            {
                var num1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var num2 = nums[j];
                    if (num1 + num2 == target)
                    {
                        retArr[0] = i;
                        retArr[1] = j;
                        return retArr;
                    }
                }
            }
    
            return null;
        }
        
        public static int[] PlusOne(int[] digits)
        {
            var carry = 0;
            var intList = digits.ToList();
            
            for (int i = digits.Length - 1; i>=0 ; i--)
            {
                if (digits[i] == 9)
                {
                    intList[i] = 0;
                }
                else
                {
                    intList[i] += 1;
                    return intList.ToArray();
                }
                
            }
            intList.Add(0);
            intList[0] = 1;
            return intList.ToArray();
        }

        public static  int MySqrt(int x) {
            long r = x;
            while (r*r > x)
                r = (r + x/r) / 2;
            return (int)r;
        }
    }
}