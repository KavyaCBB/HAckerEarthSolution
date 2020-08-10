using System;
namespace tset
{
    public class StringManipulation
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter number");
            Console.ReadLine();
            int i, j;
            int[,] arr1 = new int[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        static  public  string  stringmani()
        {
            return "";
        }
    }
}
