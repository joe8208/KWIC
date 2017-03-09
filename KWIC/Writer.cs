using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Writer : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            foreach (string line in input)
            {
                Console.WriteLine();
                Console.WriteLine(line);
            }

            Console.ReadLine();
            return input;
            //yield break;
        }
    }
}
