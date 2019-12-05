﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProjektArbete
{
    class Menu
    {
        //Startmenu
        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("      Welcome to Hangman!");
            Console.WriteLine("  made by Daniel, Huy & Jonatan! \n \n");

            Console.WriteLine("    ######   Meny   ##### \n");
            Console.WriteLine("    ##  1. Start game  ##");
            Console.WriteLine("    ##  2. HighScore   ##");
            Console.WriteLine("    ##  3. WordList    ##");
            Console.WriteLine("    ##  4. Quit        ##");
            Console.WriteLine("                    ");
                Console.Write("      Input: ");
            string mainMenu = Console.ReadLine();

            switch (mainMenu)
            {
                case "1":
                    break;

                case "2":
                    HighScore.HighScoreList();
                    break;

                case "3":
                    Words.WordsFromText();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("You are now quitting...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Wrong input, write number silly! \n and press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}