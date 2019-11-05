using System;
using System.Collections.Generic;
using ImplementDataAccess;
using System.IO;
using System.Linq;

namespace ImplementDataAccess.QueryAndManipulateDataWLINQ
{
    public class QueryDataUsingOperators
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("/Users/milesward/Projects/ImplementDataAccess/ImplementDataAccess/QueryAndManipulateDataWLINQ/QueryUsingOperators/fuel.csv");


            //method syntax
            var top = cars.Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
                            .OrderByDescending(c => c.Combined)
                            .ThenBy(c => c.Name)
                            .First();

            // The First() operator does not use deferred execution, and the
            // query executes immediately. The top variable can now be used
            // as an instance of a car.

            Console.WriteLine(top.Name);

            //query syntax
            var query2 =
                from car in cars
                where car.Manufacturer == "BMW" && car.Year == 2016
                orderby car.Combined descending, car.Name ascending
                select car;

            // ANONYMOUS TYPES

            // Declaring an object of no specific type and assigning
            // characteristics to it.

            var result = cars.Select(c => new
            {
                c.Manufacturer,
                c.Name,
                c.Combined
            });

            // if you hover over the properties above, they are of an
            // anonymous type. This means that if you try to send this
            // data somewhere, you are not potentially transferring
            // a huge amount of extra data with those objects.

            Console.WriteLine(result);

            // Print out the top ten
            foreach (var car in query2.Take(10))
            {
                Console.WriteLine($"{car.Manufacturer}{car.Name} :" +
                    $" {car.Combined}");
            }

            

            // QUANTIFIERS

                // Any()
                // This just 

                // This just returns a bool that represents whether or not
                // there are any elements at all in the collection.
                //      bool result1 = cars.Any();

                // Do any cars have a manufacturer of Ford?
                // as soon as the Any method finds something that is a ford,
                // it retuns true.
                //      bool result2 = cars.Any(c => c.Manufacturer == "Ford");

                // Do all the cars have a manufacturer of Ford?
                // as soon as the all method finds something that isn't a ford,
                // it retuns false.
                //      bool result3 = cars.All(c => c.Manufacturer == "Ford");

            // PROJECTING DATA

                /* Projection refers to the operation of transforming an object
                 * into a new form that often consists only of those properties
                 * that will be subsequently used. By using projection, you can
                 * construct a new type that is built from each object.
                 *
                 * Extension methods are perfect. See the Car.cs file for the
                 * .ToCar() extension method.  
                 */

                // Primary projection operator is .Select()
        }

        private static List<Car> ProcessFile(string path)
        {
            var query =

                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(line => line.Length > 1)
                    .ToCar(); // This is the extension method that projects
                             // car info from the CSV file line into a car
                             // object
            return query.ToList();


            // IN QUERY SYNTAX
            //var query =
            //    from line in File.ReadAllLines(path).Skip(1)
            //    where line.Length > 1
            //    select Car.ParseFromCsv(line);

            //return query.ToList();
        }
    }
}
