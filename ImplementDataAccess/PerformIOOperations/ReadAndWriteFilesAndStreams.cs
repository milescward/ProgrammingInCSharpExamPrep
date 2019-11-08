using System;
using System.IO;

namespace ImplementDataAccess.PerformIOOperations
{
    public class ReadAndWriteFilesAndStreams
    {
        /*If you want to add data to an existing file that may already exist,
         * then you should use an Appendxxx method. If you want to overwrite
         * an existing file, then you should use a Writexxx method. Then,
         * depending on how you want the information is stored (whether as
         * binary data, a textual blob in a string, or an array of strings
         * representing each individual line) use the xxxAllBytes, xxxAllText,
         * or xxxAllLines method.*/

        static void Main(string[] args)
        {
            string path = "/Users/milesward/Projects/ImplementDataAccess/ImplementDataAccess/PerformIOOperations/test.txt";
            string[] content = { "Hello,", "world" };
            File.AppendAllLines(path, content);
        }
    }
}
