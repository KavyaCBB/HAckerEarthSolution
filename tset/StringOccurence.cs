using System;
using System.Collections.Generic;
using System.Text;

namespace tset
{
    public class StringOccurence
    {
        public StringOccurence()
        {
            //StringBuilder sb = new StringBuilder();
            //int a = 0;
            //string s = Console.ReadLine();
            //string s1 = Console.ReadLine();
            //int i = 0;
            //while (true)
            //{
            //    a = s.IndexOf(s1, a);
            //    if (a > 0)
            //    {
            //        sb.Append(a.ToString());
            //        sb.Append(" ");
            //        a++;
            //    }
            //    else { break; }
            //}
            //String s3 = sb.ToString();
            //s3 = s3.Trim();
            //Console.WriteLine(s3);


            int length = Convert.ToInt32(Console.ReadLine());

            string[] inputString = new string[length];

            for (int i = 0; i < length; i++)
            {
                string ip = Console.ReadLine();
                inputString[i] = ip;
            }

            string[] test = new string[] { };
            // List<string> list = inputString[].Split(' ').ToList();
            List<string> myList = new List<string>();


            //  string[] lines = inputString[].Split(new string[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < inputString.Length; i++)
            {


                int min = Convert.ToInt32(inputString[i].Split(' ')[1].ToString());
                int max = Convert.ToInt32(inputString[i].Split(' ')[2].ToString());
                char[] cr = null;
                string result = "";
                if (min < max)
                {
                    if (inputString[i].Split(' ')[0].Length >= max)
                    {
                        string start = "";
                        string end = "";
                        // string r=  "hellsasas 1 5";
                        if (min > 0)
                        {
                            start = inputString[i].Split(' ')[0].Substring(0, min);
                        }
                        //else if (min == 0)
                        //{
                        //    start = inputString[i].Split(' ')[0].Substring(0, 1);
                        //}

                        if (max < inputString[i].Split(' ')[0].Length - 1)
                        {
                            end = inputString[i].Split(' ')[0].Substring(max, inputString[i].Split(' ')[0].Length - 1 - max);
                        }
                        else if (max == inputString[i].Split(' ')[0].Length - 1)
                        {
                            end = inputString[i].Split(' ')[0].Substring(max, 1);
                        }


                        cr = inputString[i].Split(' ')[0].Substring(min, max).ToCharArray();



                        Array.Sort(cr);
                        Array.Reverse(cr);

                        result = start + new string(cr) + end;

                        Console.WriteLine(result);
                    }
                }

            }
        }

    }
}
