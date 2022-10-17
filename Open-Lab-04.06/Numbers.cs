using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            #region Solution1

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;
            }
            int[] evens = new int[count];
            int t = 0;

            foreach (var t1 in numbers)
            {
                if (t1 % 2 == 0)
                {
                    evens[t] = t1;
                    t++;
                }
            }
            return evens;

            #endregion

            #region Solution2

            //var evens = new List<int>();
            //foreach (var t1 in numbers)
            //{
            //    if (t1 % 2 == 0)
            //    {
            //        evens.Add(t1);
            //    }
            //}
            //return evens.ToArray();

            #endregion

            #region Solution3

            //return numbers.Where(_ => _ % 2 == 0).ToArray();

            #endregion
        }
    }
}
