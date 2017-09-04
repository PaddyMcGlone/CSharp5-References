using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        // The basic units of data in Linq are Sequences and elements

        // Sequences are anything which implements the IEnuemrable interface, whereas an element is an item in a sequences
        // var names [] = { "Pat", "Sean", "Aaron" } 

        // The sequences shown above is known as a local sequence as it represents items currently held in memory
        // A query operator is a method which transforms a sequence. (takes input sequence, generates output sequence)

        static void Main(string[] args)
        {
            #region .Where()
            //string[] names = {"Tom", "Dick", "Harry"};

            //IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();
            #endregion

            #region .Select()

            // With this select query we are projecting items in the list into something new

            //string[] names = {"Pat", "Sean", "Aaron"};

            //var results = names.Select(n => n.ToUpper());

            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();


            // It is also possible to project into an anonymous type
            //var newObjects = names.Select(n => new {PlayerName = n, NameLength = n.Length});
            //foreach (var item in newObjects)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            #endregion

            #region .TakeAndSkip()

            // We use take and skip below to skip a number in the list

            // The take operators takes the first set of items and disregards the rest
            //int[] myNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            //var take = myNumbers.Take(4);

            //foreach (var num in take)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.ReadKey();

            // The skip operator is the reverse, it skips the first x then outputs the rest
            //var skip = myNumbers.Skip(5);

            //foreach (var num2 in skip)
            //{
            //    Console.WriteLine(num2);
            //}

            //Console.ReadKey();

            #endregion

            #region .ElementAt()

            // Not all query operators return a sequence, element operators extracts an element from the sequence
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 ,8, 9 ,0 };

            //All of these sequence operators will throw a null ref exception if there is a null value
            //To get around this we will use the orDefault exstension methods.

            //var first = numbers.First();
            //var last = numbers.Last();
            //var fifth = numbers.ElementAt(5);
            //var firstOdd = numbers.First(n => n % 2 == 1);

            //Console.WriteLine($"First number:{first}");
            //Console.WriteLine($"Last number:{last}");
            //Console.WriteLine($"Fifth number:{fifth}");
            //Console.WriteLine($"First odd number:{firstOdd}");

            // The difference between first and single is single will throw an exception if there is more than one match within 
            // the database

            #endregion

            #region .Aggregation()

            //Scalar value distinguishes between an int or float from a data structure such as a array
            // Aggregation methods return a scalar value

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 ,8, 9 ,0 };

            //var count = numbers.Count();
            //var min = numbers.Min();
            //var max = numbers.Max();
            //var average = numbers.Average();

            //Console.WriteLine(count);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            //Console.WriteLine(average);

            //Console.ReadKey();

            // It is possibe to extend the count operator as well too

            //Below we are only counting even numbers
            //var newCount = numbers.Count(n => n % 2 == 0);
            //Console.WriteLine(newCount);

            #endregion

            #region .Quantifiers()

            //Quantifiers return a boolean value

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 ,8, 9 ,0 };

            //var listContainsZeroDigit = numbers.Contains(0);
            //var isThisListEmpty = numbers.Any();
            //var doesThisListContainOddNumbers = numbers.Any(n => n % 2 == 1);
            //var isTheListAllOddNumbers = numbers.All(n => n % 2 == 1);

            #endregion

            #region .Set()

            // Set operators accept two sequence operators

            //Concat links one to another, union does the same but removes any duplicates

            //int[] listOne = {1, 2, 3, 4, 5, 6};
            //int[] listTwo = {1, 2, 3, 4, 5, 7};

            //var concated = listOne.Concat(listTwo);
            //var unioned = listOne.Union(listTwo);

            //foreach (var item in concated)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in unioned)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region .DefferedExecution()

            // The important thing to remember about query operators is that they are only executed when they are enumerated
            // these queries are not called when they are constructed.

            //var numbers = new List<int>();
            //numbers.Add(1);

            //IEnumerable<int> query = numbers.Select(n => n * 100);
            //numbers.Add(2);

            //foreach (var n in query)
            //    Console.WriteLine($"{n} |");

            //Console.ReadKey();


            // The number 2 which was added to query as it is not until the foreach statement is called that any filtering or sorting of the list
            // will take place, this is known as deffered execution or lazy loading and a decoupling from query execution to query loading.

            // This means we can construct a query over multiple steps, however any operator which returns elements such as tolist or quantifiers
            // do not have lazy loading



            #endregion

            #region ChainingQueryOperators

            string[] names = {"Pat", "Sean", "Aaron", "Scamp", "Murphy"};

            var results = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (var item in results)
            {
                Console.Write(item + " |");
            }

            #endregion
        }
    }
}
