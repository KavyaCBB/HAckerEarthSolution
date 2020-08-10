using System;
namespace tset
{
    public class RemoveDuplicate
    {
        public RemoveDuplicate()
        {

            string inputString = Console.ReadLine();

            string resultString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
