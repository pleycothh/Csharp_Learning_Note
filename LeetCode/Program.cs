using System.Collections;

namespace Boxing
{
    public class Solution
    {
        int result;

        public int Search(int[] nums, int target)
        {
            // int pivot, left = 0, right = nums.Length -1;
           

            for (int i = 0; i < (nums.Length); i++)
            {
                if (nums[i] == target)
                {
                    //Console.WriteLine(i);

                    result = i;
                    break;
                }
                else if (nums[(nums.Length - i)] == target)
                {
                    //  Console.WriteLine(i);
                    //Console.WriteLine(nums[-1]);
                    result = (nums.Length - i);
                    break;

                }
                result = -1;

            }
            return result;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int result;

            var solution = new Solution();

            result = solution.Search(nums, target);

            System.Console.WriteLine(result);

        }
    }
}
