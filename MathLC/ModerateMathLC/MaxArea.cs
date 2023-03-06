using System;

namespace ModerateMathLC
{
    public static class MaxArea
    {
        public static int maxArea(int[] height)
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