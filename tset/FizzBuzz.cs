using System;
namespace tset
{
    public class FizzBuzz
    {
        public  string[] FizzBuzzFunc()
        {
           int input= Convert.ToInt16(Console.ReadLine());

            for(int i= 1; i <= input; i ++)
            {
                if ((i % 3 == 0) && ( i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");

                }
                else if ((i % 3 != 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);

                }
            }


            return null;
        }



    }
}
