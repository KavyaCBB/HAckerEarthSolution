using System;
namespace tset
{
    public class StringReverse
    {
        public StringReverse()
        {

            
        }

        public void ReverseString()
        {
            String inputString = Console.ReadLine();
            string reverseString = "";
            int length = inputString.Length - 1;
            while (length >= 0)
            {
                reverseString += inputString[length];
                length--;
            }
            Console.WriteLine(reverseString);


            char[] arr = inputString.ToCharArray();

            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.ReadLine();
            string rvrs = "";
            for (int i = inputString.Length - 1; i >= inputString.Length - 1; i--)
            {
                rvrs += inputString[i];
            }
            Console.WriteLine(inputString);
        }

        public string Palindrome(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            string reverseString = "";
            int length = inputString.Length - 1;
            while (length >= 0)
            {
                reverseString += inputString[length];
                length--;
            }

            if(inputString == reverseString)
            {
                Console.WriteLine("Plaindrome");
            }
            else
            {
                Console.WriteLine("Not aPlaindrome");
            }

            return reverseString;
        }


        public void findSmallBigNumberSpace()
        {
            string s = string.Empty;
            s = Console.ReadLine();
            int number = 0;
            int capitalLetter = 0;
            int smallletter = 0;
            int space = 0;
            int SpecialSymbol = 0;
            char[] a = s.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 48 && a[i] <= 58)
                {
                    number += 1;
                }
                else if (a[i] >= 65 && a[i] <= 90)
                {
                    capitalLetter += 1;
                }
                else if (a[i] >= 97 && a[i] <= 122)
                {
                    smallletter += 1;
                }
                else if (a[i] == 32)
                {
                    space += 1;
                }
                else
                {
                    SpecialSymbol += 1;
                }
            }
            Console.Write("Capital Letter              " + capitalLetter);
            Console.Write("\nsmall letter              " + smallletter);
            Console.Write("\nnumber are                " + number);
            Console.Write("\nTotal Spaces              " + space);
            Console.Write("\nTotal Special Symbol are  " + SpecialSymbol);
            Console.ReadLine();
        }

        public void StringCompare()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int n = string.Compare(s1, s2, false);
            //int n = s1.CompareTo(s2);  
            Console.Write(n);
            Console.ReadLine();
        }

    }
}
