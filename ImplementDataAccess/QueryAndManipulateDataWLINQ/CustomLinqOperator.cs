using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementDataAccess.QueryAndManipulateDataWLINQ
{
    public static class CustomLinqOperator
    {
        /* This is the basic way that Linq operators are implemented
         * 1. Extension method on IEnumerable<T>
         * 2. Typically a Func parameter that is passed in to indicate
         *    what to perform the method on.
         * 3. Yield return is used in the loop to momentarily return
         *    control to calling method for item manipulation, then
         *    resumes after calling method manipulation is complete.
         */
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                                Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        public static IEnumerable<double> Random()
        {
            var random = new Random();
            while (true)
            {
                yield return random.NextDouble();
            }
        }

        /*************** TESTING ******************/
        /* Ensure Main method is only active Main uncommented */
        /* Delete beginning and end line comments and run program */
        /* Output is 0 2 4 6 8 */


        /*
        static void Main(string[] args)
        {
            var nums = Enumerable.Range(0, 10);
            var query = nums.Filter(n => n % 2 == 0);
            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
        }
        */
    }
}
