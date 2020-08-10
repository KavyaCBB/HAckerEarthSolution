using System;
using System.Collections.Generic;
using System.Linq;

namespace tset
{
    public class StringAlaganCountinInputDictionary
    {
        public StringAlaganCountinInputDictionary()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int dictionaryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> dictionary = new List<string>();

            for (int i = 0; i < dictionaryCount; i++)
            {
                string dictionaryItem = Console.ReadLine();
                dictionary.Add(dictionaryItem);
            }

            int queryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> query = new List<string>();

            for (int i = 0; i < queryCount; i++)
            {
                string queryItem = Console.ReadLine();
                query.Add(queryItem);
            }


            List<int> result = stringAnagram(dictionary, query);

            Console.WriteLine(String.Join("\n", result));


        }



        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            int i, j = 0;
            bool KeyNotFound = false;
            string notfound = "";
            string NewWord1 = "";
            int countString = 0;

            string NewWord2 = "";
            List<string> result = new List<string>();
            List<string> resultNotFind = new List<string>();
            List<int> results = new List<int>(); ;
            for (i = 0; i < query.Count(); i++)
            {
                countString = 0;
                NewWord1 = "";
                NewWord2 = "";
                KeyNotFound = false;
                for (j = 0; j < dictionary.Count(); j++)
                {
                    string word1 = dictionary[j].ToString();
                    string word2 = query[i].ToString();

                    char[] char1 = word1.ToLower().ToCharArray();
                    char[] char2 = word2.ToLower().ToCharArray();

                    //Step 2  
                    Array.Sort(char1);
                    Array.Sort(char2);

                    //Step 3  
                    NewWord1 = new string(char1);
                    NewWord2 = new string(char2);

                    if (NewWord1 == NewWord2)
                    {
                        countString++;
                        //int count = dictionary.Find(x => x == NewWord1).Count();
                        result.Add(NewWord1);
                        KeyNotFound = true;
                        //Console.WriteLine("alagram exist");
                    }




                }

                if (KeyNotFound == false)
                {
                    results.Add(0);
                }
                else
                {
                    results.Add(countString);
                }

                countString = 0;
            }




            // var result1 =
            //    result.GroupBy(x => x)
            //.ToDictionary(y => y.Key, y => y.Count())
            //.ToList().Select(x => x.Value).ToList();




            // results = (List<int>)result1;


            return results;
        }
    }
}
