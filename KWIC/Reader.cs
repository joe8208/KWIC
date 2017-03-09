using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Reader : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            bool isValidFile = false;

            Console.Clear();
            Console.Title = "KWIC - Pipe and Filter";            
            string filePath = "";
            IEnumerable<string> inputFile = new List<string>();

            while (!isValidFile)
            {
                Console.WriteLine("Please enter a valid path of data file:");
                filePath = Console.ReadLine();

                try
                {
                    inputFile = File.ReadLines(filePath);
                    isValidFile = true;
                }
                catch (Exception)
                {
                    isValidFile = false;
                }                
            }


            

            //return File.ReadLines(Console.ReadLine());
            return inputFile;
        }
    }
}
