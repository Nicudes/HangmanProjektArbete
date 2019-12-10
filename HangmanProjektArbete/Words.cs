using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Documents;

namespace HangmanProjektArbete
{
    class Words
    {
        //const string WordFilePath = @"C:/Users/danie/Documents/#Testning/Projektarbete/WordFile.txt";
        const string WordFilePath = @"WordFile.txt";
        public static string WordsFromText()
        {


            List<string> wordList = new List<string>(File.ReadAllLines(WordFilePath));
            Random rnd = new Random();

            int indexwordList = rnd.Next(wordList.Count());

            string wordToCrack = wordList[indexwordList];

           

            //foreach (string words in wordList)
            //{
            //    Console.WriteLine(words);
            //}
            return wordToCrack;
        }

    }
}
