using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ControlzEx.Standard;

namespace HangmanProjektArbete
{
    public class HighScore
    {
        //Array med highscore som synkas med en .txt fil
        public const string pathHighScore = @"HighScore.txt";
        //public const string temp = @"C:\Users\danie\Documents\#Testning\Projektarbete\HangmanProjektArbete\HangmanProjektArbete\HangmanProjektArbete\HighScore.txt";

        public static void StoreHighScore()
        {
            Console.WriteLine("Enter your name for the High Score List!!");
            string nameForHighScore = Console.ReadLine();



            using (StreamWriter sw = File.CreateText(pathHighScore))
            {
                sw.WriteLine(nameForHighScore);
            }

            //return nameForHighScore;
        
        }
    }
}
