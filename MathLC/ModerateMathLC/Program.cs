using System;

namespace ModerateMathLC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test for Max Area of a rectangle
            /*var testArray = new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            Console.WriteLine(MaxArea(testArray));*/
        }

        static int MaxArea(int[] height)
        {
            int i = 0, j = height.Length-1, max = 0;

            while (i < j)
            {
                max = Math.Max(max, (j - i) * Math.Min(height[i], height[j]));

                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return max;
        }
    }
}