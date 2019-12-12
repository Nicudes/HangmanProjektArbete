﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace HangmanProjektArbete
{
    public class Game
    {
        Random random = new Random(); //  använder oss av randomFunction
        public static int life = 5;
        public bool isDead = false;
        public bool isWin = false;
        public static bool correctInput = false;
        public static string guessedLetter; // Guess är det vi skriver in för att gissa på ordet
        public static string correctWord = Words.WordsFromText(wordToCrack:"").ToUpper(); // det rätta ordet som vi tar in från en txt-fil
        public int revealedLetters = 0; // antalet bokstäver som skrivs ut 
        public static List<string> usedLetters = new List<string>();
        public static StringBuilder displayString;

        public bool checkIfWin()
        {
            if (revealedLetters == correctWord.Length)
            {
                Console.Clear();
                Console.WriteLine("YOU WON!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu:"");

                return isWin = true;
            }

            return isWin = false;
        }
        public bool checkIfDead()
        {
            if (life == 0)
            {

                Console.WriteLine("DED!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu: "");
                return isDead = true;
            }
            return isDead = false;
        }

        public void wordDisplayHandle()
        {
            displayString = new StringBuilder(correctWord.Length); // Stringbuilder visar antalet bokstäver som finns med som "_" och skriver ut de bokstäver som gissats rätt
           
            Words.WordsFromText(wordToCrack:"");
            for (int i = 0; i < correctWord.Length; i++)
                displayString.Append("_");
        }

        public bool InsertGuessToWord()
        {
            try
            {
                if (correctWord.Contains(guessedLetter))
                {
                    for (int i = 0; i < correctWord.Length; i++)
                    {
                        if (correctWord[i] == guessedLetter[0])
                        {

                            displayString[i] = correctWord[i];
                            revealedLetters++;
                        }
                    }

                }
            }
            catch (Exception)
            {

             
            }
           
            return true;
        }

        public static bool ValidInput(string guessedLetter)
        {
        
            if (correctInput = Regex.IsMatch(guessedLetter, @"^[a-zA-Z]+$"))
            {
                return true;
            }

            return false;
        }

        public bool validGuess()
        {
            if (correctInput == true && guessedLetter.Length == 1 && !usedLetters.Contains(guessedLetter))
            {

                if (correctWord.Contains(guessedLetter))
                {
                    Console.WriteLine("                   CORRECT!");
                    Thread.Sleep(1000);


                }
                else
                {
                    Console.WriteLine("                     Nope!");
                    life--;
                    Thread.Sleep(1000);
                    usedLetters.Add(guessedLetter);

                }

            }
            if (correctInput == false)
            {
                Console.WriteLine("Please enter a correct letter");
                Thread.Sleep(1000);
            }
            return true;
        }



        public void GameStart()
        {
            wordDisplayHandle();
            do
            {

                checkIfDead();
                checkIfWin();
                TextHandler.hangedMan();
                InsertGuessToWord();
                ValidInput(guessedLetter);
                validGuess();





            } while (checkIfDead() == false || checkIfWin() == true) ;


        }





    }
}
