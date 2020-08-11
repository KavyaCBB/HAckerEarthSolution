using System;
using System.Collections.Generic;

namespace tset
{
    public class DelegateExampleInterview
    {
        delegate void SomeMethod();
        public DelegateExampleInterview()
        {
            ////The program will output the number 10 times.
            ////The delegate was added 10 times.The reference to the i variable was taken.
            ////The reference, not the value.That is why, when calling a delegate, the last value of the i variable is taken.
            ///It is a typical example of closure.
 
            List<SomeMethod> delList = new List<SomeMethod>();
            for (int i = 0; i < 10; i++)
            {
                delList.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var del in delList)
            {
                del();
            }
        }
    }
}
