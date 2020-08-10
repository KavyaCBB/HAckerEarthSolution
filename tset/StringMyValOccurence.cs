using System;
namespace tset
{
    public class StringMyValOccurence
    {
        public StringMyValOccurence()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string outPut = "";
            char[] prefix = input2.Substring(0, 1).ToCharArray();
            char[] suffix = input1.Substring(input1.Length - 1, 1).ToCharArray();

            if (prefix[0] == suffix[0])
            {
                string result = input1.Replace(prefix[0], ' ');
                outPut = input2 + result;
            }


            Console.WriteLine(outPut);
        }
    }
}
