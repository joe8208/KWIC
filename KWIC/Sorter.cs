using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Sorter : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            LineComparer lineComparer = new LineComparer();

            // created new list to sort.  IEnumerable is readonly
            List<string> sortableList = input.ToList<string>();
            sortableList.Sort(lineComparer);
            return sortableList;
        }
    }
}
