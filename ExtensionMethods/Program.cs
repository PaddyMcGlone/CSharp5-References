using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    // Extension methods allow a types to have new methods added without altering the original type.
    // it is a static method of a static class with the this keyword applied to the first parameters - thats whats being extended
    class Program
    {       
        static void Main(string[] args)
        {
            string myString = "blah blah blah";
            myString = myString.CapitaliseThis();

            Console.WriteLine(myString);
        }
    }

    public static class StringHelper
    {
        public static string CapitaliseThis(this string value)
        {
            return value.ToUpper();
        }
    }
}
