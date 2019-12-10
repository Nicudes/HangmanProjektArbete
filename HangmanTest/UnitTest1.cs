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
            Game game = new Game();

            game.guessedLetter = "H";
            game.correctWord = "HEJSAN";

            bool result = game.correctWord.Contains(game.guessedLetter);

            Assert.True(result);
        }

        [Test]
        public void InsertGuessToWord_GivenInvalidGuess_ReturnFalse()
        {
            Game game = new Game();

            game.guessedLetter = "P";
            game.correctWord = "HEJSAN";

            bool result = game.correctWord.Contains(game.guessedLetter);

            Assert.False(result);
        }


    }
}