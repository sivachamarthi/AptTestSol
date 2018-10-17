using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SumOfBiggestNumber
{
    public class SumFider
    {
        public int Challenge(int[] input)
        {
            var rankResult = RankItemsAndFindHighest(input);
            
            var repeatedItemResult = GetSumOfBiggestNumbers(input, rankResult.dict, rankResult.M);
            
            return repeatedItemResult;
        }

        /// <summary>
        /// Get the item counts and highest count (M) values
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private (Dictionary<int, int> dict, int M) RankItemsAndFindHighest(int[] input)
        {
            Dictionary<int, int> itemRanks = new Dictionary<int, int>();
            int highestCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];

                //update the count if already exists in dict
                if (itemRanks.ContainsKey(item))
                {
                    itemRanks[item] += 1;
                    if (highestCount < itemRanks[item])
                        highestCount = itemRanks[item];
                }
                else
                {
                    itemRanks[item] = 1;
                    if (highestCount <= 1) highestCount = 1;
                }
            }

            return (itemRanks, highestCount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="itemCounts"></param>
        /// <param name="highestCount"></param>
        /// <returns></returns>
        private int GetSumOfBiggestNumbers(int[] input, Dictionary<int, int> itemCounts, int highestCount)
        {
            int requiredCount = highestCount - 1; // (M-1)
            int prevItem = 0;
            int biggestSum = 0;
            int curSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //Check if item count is greater than or equal to required(M-1) 
                if (itemCounts[input[i]] >= requiredCount)
                {
                    //Console.WriteLine($"{input[i]}");
                    curSum = input[i] + prevItem;
                    prevItem = input[i];
                    if (curSum > biggestSum)
                        biggestSum = curSum;
                }
            }

            return biggestSum;
        }
    }
}
