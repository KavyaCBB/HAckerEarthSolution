using System;
namespace tset
{
    public class Singleton
    {
        //create an object of SingleObject
        private static Singleton instance = new Singleton();

        //make the constructor private so that this class cannot be
        //instantiated

        private Singleton()
        {
        }

        //Get the only object available
        public static Singleton getInstance()
        {
            return instance;
        }

        #region "lock -- need to comment above code "
        private static readonly object mutex = new object();
        private static Singleton obj = null;
        public static Singleton getObj
        {
            get
            {
                lock (mutex)
                {
                    if (obj == null)
                    {
                        obj = new Singleton();
                    }
                    return obj;
                }
            }
        }
        #endregion
        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }

    }

    /////Uncomment
    //public class SingletonPatternDemo
    //{
    //    public static void main(String[] args)
    //    {

    //        //illegal construct
    //        //Compile Time Error: The constructor SingleObject() is not visible
    //        //SingleObject object = new SingleObject();

    //        //Get the only object available
    //        SingleObject object = SingleObject.getInstance();

    //        //show the message
    //        object.showMessage();
    //    }
    //}

}
