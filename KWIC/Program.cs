using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KWIC
{
    /// <summary>
    /// Pulled from sample program found at
    /// 
    /// https://dzone.com/articles/pipes-and-filters-pattern-net
    /// Which pulled samples from 
    /// https://ayende.com/blog/3082/pipes-and-filters-the-ienumerable-appraoch
    /// Changes have been made to make the sorting work, and make the input and write filter completly interchangable.
    /// not found in the smaple solution.  The keep the input "filter" in the begining and the write towards the end.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            KwicPipeline pipeline = new KwicPipeline();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            pipeline.Execute();
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
            Console.ReadLine();
        }
    }
}
