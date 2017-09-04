using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        #region .Fibonnaci sequence

        // What ia an Enumerator : it is a list which simply moves forward over a list of values
        // a for-each statement simply moves through an enumartable list

        //Where a foreach statement consumes an enumerable list, a Iterator produces an enumerable list


        // Using an iterator to return the Fibonacci sequence of numbers
        //static void Main(string[] args)
        //{
        //    foreach (var fib in Fibs(6))
        //    {
        //        Console.WriteLine(fib + " ");
        //    }
        //}

        //static IEnumerable<int> Fibs(int fibCount)
        //{
        //    for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
        //    {
                // in each yeild statement, control is returned to the caller, but allows the caller to 
                // continue executing the method.

        //        yield return prevFib;
        //        int newFib = prevFib + curFib;

        //        prevFib = curFib;
        //        curFib = newFib;
        //    }
        //}

        #endregion

        #region Iterators

        // An iterator is a method that has one or more yeild statements, that always return an enumerable result

        public static void Main()
        {
            foreach (var item in Foo())
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<string> Foo()
        {
            yield return "1";
            yield return "2";
            yield return "3";

            yield break; // Highlights that the compiler should stop early
            yield return "4";

        }

        #endregion
    }
}
