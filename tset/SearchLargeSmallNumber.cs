using System;
namespace tset
{
    public class SearchLargeSmallNumber
    {
        public void searchNumber()
        {
            //Console.WriteLine("enter num of digits");
            int length = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("enter numbers");
            //int[] val= new int[10];
            //for (int i = 0; i < val.Length; i++)
            //{

            //        val[i] = Convert.ToInt32(Console.ReadLine());
            //}

            string input = Console.ReadLine();

            string[] inputString = input.Split(' ');
            int[] intArray = new int[inputString.Length];

            for (int i = 0; i < length; i++)
            {
                intArray[i] = int.Parse(inputString[i]);
                //Console.WriteLine(intString[i]);
            }




            int small = PrintSmallestLargest(intArray);
            Console.WriteLine(small);
        }


        public int PrintSmallestLargest(int[] arr)
        {
            if (arr.Length > 0)
            {
                int small = arr[0];
                int large = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (large < arr[i])
                    {
                        int tmp = large;
                        large = arr[i];
                        arr[i] = large;
                    }
                    if (small > arr[i])
                    {
                        int tmp = small;
                        small = arr[i];
                        arr[i] = small;
                    }
                }
                // Console.WriteLine("Smallest is {0}", small);
                // Console.WriteLine("Largest is {0}", large);
                return small;
            }

            return 0;
        }
    }
}
