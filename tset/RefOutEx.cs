using System;
namespace tset
{
    public class RefOutEx
    {

        //       Since SomeMethod does not contain the ref or out keyword in the parameter,
        //           the value is passed by value, not by reference, which means that someInt will not be changed.

        //The ref and out keywords mean that the values are passed by reference
        // But in the second case, a value must be assigned to the parameter in the method.
        //               In our example, in the SomeMethod2 method, a value must be assigned to the value parameter.



        //What are verbatim strings?
       // Answer

       // Everybody knows what these strings are and
        //constantly uses them, but not everyone knows their name.
        //Verbatim strings are strings that start with the @ symbol in which the escape sequences are not processed.



        public RefOutEx()
        {
            int someInt;
            SomeMethod2(out someInt);
            Console.WriteLine(someInt);


            SomeMethod1(ref someInt);
            Console.WriteLine(someInt);

            SomeMethod(ref someInt);
            Console.WriteLine(someInt);

            SomeMethod3(someInt);
            Console.WriteLine(someInt);

            Console.ReadLine();

           

        }

        static void SomeMethod3(int value)
        {
            value = 3;
        }
        static void SomeMethod(ref int value)
        {
            value = 0;
        }
        static void SomeMethod1(ref int value)
        {
            value = 1;
        }
        static void SomeMethod2(out int value)
        {
            value = 2;
        }
    }
}
