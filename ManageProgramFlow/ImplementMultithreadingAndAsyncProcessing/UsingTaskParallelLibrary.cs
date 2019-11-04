using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace ManageProgramFlow
{
    public class UsingTaskParallelLibrary
    {
        /* Task Parallel Library provides three methods to create
         * applications that execute in parallel:
         * 1) Parallel.Invoke
         * 2) Parallel.ForEach
         * 3) Parallel.For
         *
         * See below for methods used to demonstrate the above
         * methods. Methods specific to one of the three are
         * preceeded by significant attributes.
         */

        static void Task1()
        {
            Console.WriteLine("T1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("T1 Ending");
        }

        static void Task2()
        {
            Console.WriteLine("T2 starting");
            Thread.Sleep(2000);
            Console.WriteLine("T2 Ending");
        }

        static void WorkOnItem(Object item)
        {
            Console.WriteLine("working on: {0}", item);
            Thread.Sleep(2000);
            Console.WriteLine("Finished working on {0}", item);
        }

        // -----Delete the comment icon below and the icon at the bottom of
        // the file to run the program------

            /*

        static void Main(string[] args)
        {
            // PARALLEL.INVOKE:
               //- Takes a number of Action delegates and turns them into tasks
               //- Action delegate can be replaced with a lambda expression

            Console.WriteLine("Parallel.Invoke:");
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished Tasks 1 and 2");
            Console.WriteLine();


             //PARALLEL.FOREACH:
               //- Accepts two parameters: an IEnumerable collection and
                 //the action to be performed on each item in the collection
               //- Tasks are not completed in the same order started
            
            Console.WriteLine("Parallel.ForEach:");
            var items1 = Enumerable.Range(0, 5);
            Parallel.ForEach(items1, item =>
            {
                WorkOnItem(item);
            });

            Console.WriteLine("All Done");
            Console.WriteLine();

            // PARALLEL.FOR:
               //- Used to control execution on a loop
               //- Takes three parameters, the initial index, the length
               // of the array, and a lambda expression for execution on
               // each item in the array.
               //- Tasks are not completed in the same order started
            

            // PARALLEL.FOR and FOREACH can take an additional parameter
            // on the lambda of type ParallelLoopState and retun return
            // a value of ParallelLoopResult
            Console.WriteLine("Parallel.For:");
            var items2 = Enumerable.Range(0, 5).ToArray();
            ParallelLoopResult result = Parallel.For(0, items2.Length, (int i,
                ParallelLoopState loopState) =>
            {
                if (i == 5)
                {
                    loopState.Stop();
                }
                WorkOnItem(items2[i]);
            });

            Console.WriteLine("All Done");
           
        }
        */
    }
}
