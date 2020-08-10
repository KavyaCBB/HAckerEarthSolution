using System;
using System.Collections.Generic;

namespace tset
{
    public class Palindrome
    {
        

        public string palindromeSingle()
        {
            string s, result, revs = "";
            // Console.WriteLine(" Enter string");  
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                result = "String is Palindrome \n Entered String Was" + s + " and reverse string is " + revs;

                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
                result = "String is not Palindrome \n Entered String Was " + s + " and reverse string is {1}" + revs;
            }
            //Console.ReadKey();

            return result;
        }

        public void PalindromeList()
        {
            string result, revs = "";
            // Console.WriteLine(" Enter string");

            int length = Convert.ToInt32(Console.ReadLine());

            List<string> inputString = new List<string>();

            for (int i = 0; i < length; i++)
            {
                string ip = Console.ReadLine();
                inputString.Add(ip);
            }
            //s = Console.ReadLine();

            foreach (string s in inputString)
            {
                revs = "";
                for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
                {
                    revs += s[i].ToString();
                }
                if (revs == s) // Checking whether string is palindrome or not  
                {
                    // result = "String is Palindrome \n Entered String Was" + s + " and reverse string is " + revs;

                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                    //result = "String is not Palindrome \n Entered String Was " + s + " and reverse string is {1}" + revs;
                }
            }

        }
    }
}
