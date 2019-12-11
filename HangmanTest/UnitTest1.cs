using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HangmanProjektArbete;

namespace HangmanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Startmenu_InputLetter_CorrectLetterInput()
        {
            Menu menu = new Menu();

            string mainMenu = "1";
            string expected = "1";

            string result = mainMenu;

            StringAssert.Contains(mainMenu, expected);
        }

        [Test]
        public void Startmenu_InputLetter_IncorrectSymbolInput()
        {
            Menu menu = new Menu();

            string mainMenu = "!";
            string expected = "1";

            string result = mainMenu;

            StringAssert.DoesNotContain(mainMenu, expected);
        }

        [Test]
        public void Startmenu_InputLetter_IncorrectHighNumberInput()
        {
            Menu menu = new Menu();

            string mainMenu = "8";
            string expected = "1";

            string result = mainMenu;

            StringAssert.DoesNotContain(mainMenu, expected);
        }
       
        [Test]
        public void InsertGuessToWord_GivenValidGuess_ReturnTrue()
        {

            Game.guessedLetter = "H";
            Game.correctWord = "HEJSAN";

            bool result = Game.correctWord.Contains(Game.guessedLetter);

            Assert.True(result);
        }

        [Test]
        public void InsertGuessToWord_GivenInvalidGuess_ReturnFalse()
        {

            Game.guessedLetter = "P";
            Game.correctWord = "HEJSAN";

            bool result = Game.correctWord.Contains(Game.guessedLetter);

            Assert.False(result);
        }


    }
}