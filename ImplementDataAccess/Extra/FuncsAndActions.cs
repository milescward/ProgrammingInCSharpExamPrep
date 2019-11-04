using System;
namespace ImplementDataAccess.Extra
{
    public class FuncsAndActions
    {
        /* Funcs and Actions*/
        /* Funcs and Actions are delegate types that are used to
         * define simple in-line methods. These delegates often
         * employ lambda expressions.
         *
         * Whats the difference?
         * An Action<T> is a delegate that can take up to 16 parameters
         * and returns void.
         * 
         * A Func<T, TResult> is a delegate that takes up to 17 parameters, with the
         * final parameter being the return type of the Func.
         *
         * Both are usually followed by a lambda expression
         */

        // Func declaration:
        //this function takes an integer as a parameter and returns an integer
        Func<int, int> squared = x => x * x;

        // Action Declaration
        // This action simply writes to the console using the write Action
        Action<string> write = x => Console.WriteLine(x);

    }
}
