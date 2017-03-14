using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class NoiseRemover : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            // get list of noise words.
            List<string> listOfWords = input.ToList();

            IEnumerable<string> noiseWordsFile = new List<string>();

            noiseWordsFile = File.ReadLines("noiseword.txt").ToList();

            // iterate and remove any lines that start with any of the noise words.
            foreach(string line in input)
            {
                string[] words = line.Split(new char[] { ' ' });

                // check to see if the first word in line matches a noise word

                foreach (string noiseWord in noiseWordsFile)
                {
                    if (words[0].ToLower() == noiseWord.ToLower())
                    {
                        listOfWords.Remove(line);
                    }
                }
                
            }

            //throw new NotImplementedException();
            return listOfWords;
        }
    }
}
