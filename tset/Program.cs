using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tset
{
    class Program
    {
        delegate void SomeMethod();
        static void Main(string[] args)
        {
           

            
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







