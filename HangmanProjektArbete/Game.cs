using System;
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
        public int life = 3;
        public bool correctInput = false;
        public string guessedLetter; // Guess är det vi skriver in för att gissa på ordet
        public string correctWord = Words.WordsFromText().ToUpper(); // det rätta ordet som vi tar in från en txt-fil
        //public string trueGuessBuild;
        public int revealedLetters = 0; // antalet bokstäver som skrivs ut 
        List<string> usedLetters = new List<string>();
        StringBuilder displayString;

        public bool checkIfWin()
        {
            if (revealedLetters == correctWord.Length)
            {
                Console.Clear();
                Console.WriteLine("YOU WON!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu:"");

                return true;
            }

            return false;
        }
        public bool checkIfDead()
        {
            if (life == 0)
            {

                Console.WriteLine("DED!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu: "");
                return true;
            }
            return false;
        }
        public void hangedMan()
        {
            Console.WriteLine(correctWord);
            Console.Clear();
            if (life == 5)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                //Console.WriteLine("           " + trueGuessBuild + "              ");

                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (life == 4)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                //Console.WriteLine("           " + trueGuessBuild + "              ");



                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (life == 3)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("           " +displayString + "              ");



                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            if (life == 2)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                //Console.WriteLine("           " + trueGuessBuild + "              ");
                Console.WriteLine("           " + displayString + "              ");



                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (life == 1)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine(@"|                     |           |             |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                //Console.WriteLine("           " + trueGuessBuild + "              ");



                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            if (life == 0)
            {
                Console.WriteLine($"               The Hangman Game      HP: {life}                           ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                 RIP                           |                   ");
                Console.WriteLine("|            U DED OK?                          |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine(@"|                     |          /|\            |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                //Console.WriteLine("              " + trueGuessBuild + "              ");


                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            foreach (var item in usedLetters)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------                   ");
            Console.WriteLine("                 Guess a letter                                       ");

            Console.WriteLine(correctWord);
    
            guessedLetter = Console.ReadLine().ToUpper();


        }

        public void wordDisplayHandle()
        {
            displayString = new StringBuilder(correctWord.Length); // Stringbuilder visar antalet bokstäver som finns med som "_" och skriver ut de bokstäver som gissats rätt
           
            Words.WordsFromText();
            for (int i = 0; i < correctWord.Length; i++)
                displayString.Append("_");
        }

        public bool InsertGuessToWord()
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
           
            return true;
        }

        public bool ValidInput()
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
                usedLetters.Add(guessedLetter);

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
                hangedMan();
                InsertGuessToWord();
                ValidInput();
                validGuess();





            } while (checkIfDead() == false || checkIfWin() == true) ;


        }





    }
}
