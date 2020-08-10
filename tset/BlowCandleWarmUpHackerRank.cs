using System;
using System.IO;
using System.Linq;

namespace tset
{
    public class BlowCandleWarmUpHackerRank
    {

        public void callBirthday()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar, arCount);

            Console.WriteLine(result);
        }
        
        int birthdayCakeCandles(int[] arr, int arcount)
        {
            int list = 0;
            if (arr.Length > 0)
            {
                int small = arr[0];
                int large = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (large < arr[i])
                    {
                        int tmp = large;
                        //  large = arr[i];
                        arr[i] = large;
                    }
                    if (small > arr[i])
                    {
                        int tmp = small;
                        small = arr[i];
                        arr[i] = small;
                    }

                }

                list = arr.Where(x => x == large).ToArray().Length;

                //Console.WriteLine("Smallest is {0}", small);
                //   Console.WriteLine("Largest is {0}", large);
                // string combindedString = string.Join(",", list);

                //  Console.WriteLine(combindedString);
            }
            return list;
        }
    }
}
        