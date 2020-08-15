using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace tset
{
    public class LinqExamples
    {
        public LinqExamples()
        {
            ////LAMBDA EXPRESSION
            //The lambda Expression can be assigned to the Func or Action type delegates to process over in-memory collections.

            //The.NET compiler converts the lambda expression assigned to Func or Action type delegate into executable code at compile time.

            //Func<Student, bool> isTeenAger = s => s.Age > 12 && s.Age < 20;   --- this is delegate
            // And now, you can convert the above Func type delegate into an Expression by wrapping Func delegate with Expresson, as below:


            Func<Student, bool> isTeenAgerExpr1 = s => s.Age > 12 && s.Age < 20;

            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            //compile Expression using Compile method to invoke it as Delegate
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            //Invoke
            bool result = isTeenAger(new Student() { StudentID = 13, StudentName = "Steve", Age = 19 });

            Console.WriteLine(result);


            // Deferred execution

            //Deferred execution means that the evaluation of an expression is
            //    delayed until its realized value is actually required.
            //    It greatly improves performance by avoiding unnecessary execution

            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 12 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
             };

            List<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var teenAgerStudents = from s in studentList.GetTeenAgerStudents()
                                   select s;

            //In the above example, you can see the query is materialized and
            //    executed when you iterate using the foreach loop.This is called deferred execution.
            //    LINQ processes the studentList collection when you
            //    actually access each object from the collection and do something with it.

            foreach (Student teenStudent in teenAgerStudents)
                Console.WriteLine("Student Name: {0}", teenStudent.StudentName);


            //Immediate execution is the reverse of deferred execution. It forces the LINQ query
            //to execute and gets the result immediately.
            //The 'To' conversion operators execute the given query and give the result immediately.


            
            List<Student> teenAgerStudentss =
                studentList.Where(s => s.Age > 12 && s.Age < 20).ToList(); //The Conversion operators in LINQ are useful in converting the type of the elements in a sequence(collection).
            //There are three types of conversion operators: As operators(AsEnumerable and AsQueryable), To operators(ToArray, ToDictionary, ToList and ToLookup), and Casting operators(Cast and OfType).



            //Let
            //The 'let' keyword is useful in query syntax.
            //It projects a new range variable, allows re-use of the expression and makes the query more readable
            var lowercaseStudentNames = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;

            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);


            //Into
            // Use into keyword in LINQ query to form a group or to continue a query after a select clause.

            var teenAgerStudentsINTO = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select s
                                     into teenStudents
                                   where teenStudents.StudentName.StartsWith("B")
                                   select teenStudents;


            //
            //SAMPLE QUERRIES
            //
            //1. Multiple Select and where operator

            var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StudentID > 0)
                              .Select(s => s.StudentName);
            //LINQ Query returns Collection of Anonymous Objects
            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));


            //GroupBy
            var StudentListGoupBY = from s in studentList
                                    group s by s.StudentID into sg
                                    orderby sg.Key
                                    select new { sg.Key, sg};
            foreach(var group in StudentListGoupBY )
            {
                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }




            //Sort or orderBY

            var sortedStudents = from s in studentList
                                 orderby s.StudentID, s.Age
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     Age = s.Age,
                                     StandardID = s.StudentID
                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandardID));



            //NestedQuery
            var nestedQueries = from s in studentList
                                where s.Age > 18 && s.StudentID ==
                                    (from std in standardList
                                     where std.StandardName == "Standard 1"
                                     select std.StandardID).FirstOrDefault()
                                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            var joinLinqQuery =( from s in studentList
                                join d in standardList on s.StudentID equals d.StandardID
                                where s.Age > 20
                                select new { s.StudentID,s.Age,s.StudentName ,d.StandardID,d.StandardName }).ToList();


            var LetfJoinLinqQuery = (from s in studentList
                                     join d in standardList on s.StudentID equals d.StandardID into t
                                     from results in t.DefaultIfEmpty()
                                     orderby s.StudentID
                                     where s.Age > 20
                                     select new { s.StudentID, s.Age, s.StudentName, d.StandardID, d.StandardName }).ToList();
        }
    }


    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
        
    }

    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
        {

            foreach (Student std in source)
            {
                Console.WriteLine("Accessing student {0}", std.StudentName);

                if (std.Age > 12 && std.Age < 20)
                    yield return std;
            }
        }
    }

  




}

