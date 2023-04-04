namespace BaiCodeThieuNhi
{
    using System;
    using System.Diagnostics;
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    result[0] = map[complement];
                    result[1] = i;
                    return result;
                }

                map[nums[i]] = i;
            }

            return result;
        }

        /* public static void Main(String[] args)
         {
             var x = new TwoSum();
             int[] nums = new int[] { 1, 2, 3, 5, 6, 7, 8, };
              var result  = x.Solution(nums, 13);
             Console.WriteLine(result[0]);
             Console.WriteLine(result[1]);
         } */
    }

    public class BuyAndSellStock
    {
        public int[] Solution(int[] prices)
        {
            int[] result = new int[2];
            int l = 0; int r = 1;

            int maxProfit = 0;
            int currentProfit = 0;

            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                {
                    currentProfit = prices[r] - prices[l];
                    if (currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                        result[0] = l;
                        result[1] = r;
                    }

                }
                else
                {
                    l = r;
                }
                r++;
            }

            Console.WriteLine(maxProfit);
            return result;
        }

       /* public static void Main(String[] args)
        {
            var x = new BuyAndSellStock();
            int[] prices = new int[] { 4, 2, 3, 1, 6, 9, 8, 10 };
            var result = x.Solution(prices);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }*/
    }
}