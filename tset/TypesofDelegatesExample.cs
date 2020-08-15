using System;
using System.Collections.Generic;

namespace tset
{
    public class TypesofDelegatesExample
    {
        //There are only five steps to create and use a delegate and these are as following.

        //Declare a delegate type.
        //Create or find a method which has same type of signature.
        //Create object/instance of delegate
        //Pass the reference of method with delegate instance.
        //At last Invoke the delegate object.


        public delegate int MathDelegate(string name, string pass); //1 Declare a delegate type.
        public delegate List<customerModel> singleDelegate(int age);
          delegate void MultiCastDelegate();

        public TypesofDelegatesExample()
        {

        }
        public void DeclareDelegate()
        {
            MathDelegate objMathDelegate = null;//3 Create object/ instance of delegate
            objMathDelegate += customer.GetID;  // 4 Pass the reference of method with delegate instance.
            int result = objMathDelegate.Invoke("Kavya", "ya");//5 At last Invoke the delegate object.



            // When Delegate takes reference with single method only then it is called Single Delegate.
            //It is used for invocation of only one reference method
            //singleDelegate is referring only one GetAllCustomer method

            singleDelegate objSingleDelegate = new singleDelegate(customer.GetAllCustomer);

            List<customerModel> result2 = objSingleDelegate.Invoke(1);
            //customer cust = new customer();

            //When Delegate takes reference with multiple methods then it is called multicast delegate.
             //   It is used for invocation of multiple reference methods.We can add or remove
            //references of multiple methods with same instance of delegate using (+) or(-) sign respectively.
           // It need to consider here that all methods will be invoked in one process and that will be in sequence.


             MultiCastDelegate objMultiCastDelegate = null;
            //Referencing the multiple methods using + sign
            objMultiCastDelegate += customer.CutomerSalary;   // --- cannot access with instance of customer
            objMultiCastDelegate += customer.CutomerSalaryReport;
            objMultiCastDelegate.Invoke();


        }
    }

    public class customer
    {
        public static int GetID(string name, string pass) //2 Create or find a method which has same type of signature
        {
            int custid = 11;
            return custid;
        }

        public static List<customerModel> GetAllCustomer(int age) //2 Create or find a method which has same type of signature
        {
            customerModel cust = new customerModel();

            cust.Custid = 1;
            cust.Name = "kavya";
            cust.Salary = 2002;

            List<customerModel> custList = new List<customerModel>();
            custList.Add(cust);


            return custList;
        }

        public static void  CutomerSalary() //2 Create or find a method which has same type of signature
        {
            customerModel cust = new customerModel();

            cust.Custid = 1;
            cust.Name = "kavya";
            cust.Salary = 2002;

            List<customerModel> custList = new List<customerModel>();
            custList.Add(cust);

            Console.WriteLine("Customer Salary");
            
        }
        public static void CutomerSalaryReport() //2 Create or find a method which has same type of signature
        {
            customerModel cust = new customerModel();

            cust.Custid = 1;
            cust.Name = "kavya";
            cust.Salary = 2002;

            List<customerModel> custList = new List<customerModel>();
            custList.Add(cust);

            Console.WriteLine("Customer Salary");

        }


    }



    public class customerModel
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

    }
}
