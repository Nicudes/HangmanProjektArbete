using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace HangmanProjektArbete
{
    class Game
    {
        //Hanterar gissningar o sånt. 
        //list med incorrect guesses
        //list med correct guesses

        public static void GameStart()
        {
            int life =10;
            string guessedLetter;
            string correctWord = "BANAN";
            bool correctInput = false;
  
            //ta in ett ord från Words.cs 
            //skriv ut en "bild" på spelet
            //ha en ruta där du kan skriva in en gissning
            //skriv ut om den finns med eller inte 
            //om den finns med så sätter ut tecknet 
            //om den inte finns, lägg till grafiskt och ta bort ett liv 


            List<string> usedLetters = new List<string>();
          
            do
            {
                Console.WriteLine(correctWord);
                Console.Clear();
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
                Console.WriteLine("|              _ _ _ _ _ _ _ _                  |                   ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

                foreach (var item in usedLetters)
                {
                        Console.Write(item + ", ");
                }
          
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                 Guess a letter                                       ");


                guessedLetter = Console.ReadLine().ToUpper();
        

                if (correctInput = Regex.IsMatch(guessedLetter, @"^[a-zA-Z]+$"))
                {
                    correctInput = true;
                }

                if (correctInput == true && guessedLetter.Length == 1)
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
                if (life == 0)
                {
                    Console.WriteLine("GAME OVER!");
                    Console.ReadKey();

                    Menu.StartMenu();
                }


            } while (true);



        }
    }
}
