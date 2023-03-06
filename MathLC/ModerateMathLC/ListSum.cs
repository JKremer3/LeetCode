using System;
using System.Collections.Generic;

namespace ModerateMathLC
{
    public class ListSum
    {
        //find triplets that add up to 0
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var res = new List<IList<int>>();
            
            if (nums.Length == 0)
            {
                return res;
            }

            for(int i=0; i<nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i-1])
                    continue;
                
                int targetSum = 0-nums[i];
                int left = i+1, right = nums.Length-1;

                while(left < right)
                {
                    int currSum = nums[left] + nums[right];
                    if (currSum == targetSum)
                    {
                        res.Add(new List<int>{nums[i], nums[left], nums[right]});

                        //skip duplicates
                        while(left < nums.Length-1 && nums[left] == nums[left+1])
                        {
                            left++;
                        }
                        
                        while(right>0 && nums[right] == nums[right-1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (currSum > targetSum)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return res;
        }
    }
}