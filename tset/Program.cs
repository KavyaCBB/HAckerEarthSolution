using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tset
{
    class Program
    {

 //       Since SomeMethod does not contain the ref or out keyword in the parameter,
 //           the value is passed by value, not by reference, which means that someInt will not be changed.

 //The ref and out keywords mean that the values are passed by reference
 // But in the second case, a value must be assigned to the parameter in the method.
 //               In our example, in the SomeMethod2 method, a value must be assigned to the value parameter.



        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int n = string.Compare(s1, s2, false); //This function returns 0 if both strings are equal.   DEFAULT VALUE IS FALSE


            int n2 = s1.CompareTo(s2);
           
            Console.WriteLine(n + n2);
            Console.ReadLine();

            string SS1 = "The quick brown fox jumps over the lazy dog";
            string SS2 = "lox";
            bool flag;
            flag= SS1.Contains(SS2);
          
            Console.Write(flag);
            Console.ReadLine();

        }



       

        

    }
}







