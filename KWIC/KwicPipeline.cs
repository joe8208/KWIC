using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class KwicPipeline : Pipeline<string>
    {
        public KwicPipeline()
        {    
            Console.Title = "KWIC";
            
            bool isValidFile = false;

            string filePath = "";
            IEnumerable<string> lines = new List<string>();

            while (!isValidFile)
            {
                Console.WriteLine("Please Enter the path of the file describing the filter sequence:");
                filePath = Console.ReadLine();

                try
                {
                    lines = File.ReadLines(filePath);
                    isValidFile = true;
                }
                catch (Exception)
                {
                    isValidFile = false;
                }
            }
            

            foreach (var filter in lines)
            {
                switch (filter)
                {
                    case "Reader":
                        Register(new Reader());
                        break;
                    case "Shifter":
                        Register(new Shifter());
                        break;
                    case "Writer":
                        Register(new Writer());
                        break;
                    case "Sorter":
                        Register(new Sorter());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
