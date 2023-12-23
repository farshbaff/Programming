using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class ArrayService
    {
        public static int GetSum(int[] nums)
        {
            int sum = 0;

            //foreach (var n in nums) 
            //    sum += n;

            for (int i = 0; i < nums.Length; i++)
                sum = sum + nums[i];

            return sum;
        }

        public static double GetAverage(int[] nums)
        {
            return GetSum(nums) / (double)nums.Length;
        }

        public static int GetMax(int[] nums)
        {
            int max = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
                if (nums[i] > max)
                    max = nums[i];

            //foreach (var num in nums)
            //    if(num > max)
            //        max = num;

            return max;
        }

        public static int GetMin(int[] nums)
        {
            int min = int.MaxValue;

            for (var i = 0; i < nums.Length; i++)
                if (nums[i] < min)
                    min = nums[i];

            //foreach (var num in nums)
            //    if(num < min)
            //        min = num;

            return min;
        }

        public static (int sum, double average, int min, int max) GetSumAvgMaxMin(int[] nums) =>
            (GetSum(nums), GetAverage(nums), GetMin(nums), GetMax(nums));

    }
}
