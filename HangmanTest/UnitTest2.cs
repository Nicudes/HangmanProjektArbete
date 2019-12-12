using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HangmanProjektArbete;
using System.IO;


namespace HangmanTest
{
   public class UnitTest2
    {

        [Test]
        public void StartGame_Startinglife_IsFull()
        {
            int FullLifeExpected = 5;

            int realLifeValue = Game.life;

            Assert.AreEqual(realLifeValue, FullLifeExpected);

        }

        [Test] //Det ska returna False eftersom koden är skriven att man endast är död om man life har värdet 0
        public void CheckIfDead_NegativeLife_ReturnsFalse()
        {

            Game.life = -1;
            Game game = new Game();

            bool result = game.isDead;

            Assert.False(result);
        }

        [Test]
        public void StartGame_DecreaseLife_ReturnsFour() 
        {
            Game.life = 5;
            Game.life--;
            Game game = new Game();

            int expectedLifeValue = 4;

            Assert.AreEqual(expectedLifeValue, Game.life);
        }

        [Test]
        public void StartGame_WrongType_ReturnsAreNotEqual()
        {
            double doubleLife = 5.0;

            int realLifeValue = Game.life;

            Assert.AreNotEqual(doubleLife, realLifeValue);
        }

        [Test]
        public void CheckIfDead_AreWeDead_ReturnFalse()
        {
            
            Game game = new Game();
            Game.life = 1;

            bool result = game.checkIfDead();

            Assert.False(result);

        }


        [Test]
        public void CheckIfDead_AreWeDead_ReturnTrue()
        {

            Game game = new Game();
            Game.life = 0;

            bool result = game.isDead;

            Assert.True(result);

        }
        [Test]
        public void CheckIfWin_InputWholeWord_ReturnTrue()
        {
            Game.guessedLetter = "WIN";
            Game.correctWord = "WIN";

            Game game = new Game();

            bool result = game.isWin;

            Assert.True(result);
        }

        [Test]
        public void CheckIfWin_InputTwoLetters_ReturnFalse()
        {
            Game.guessedLetter = "WI";
            Game.correctWord = "WIN";
            Game game = new Game();

            bool result = game.isWin;

            Assert.False(result);
        }

        [Test]
        public void CheckIfWin_LettersRevealedValueIsWin_ReturnTrue()
        {
            Game game = new Game();

            game.revealedLetters = Game.correctWord.Length;

            bool result = game.isWin;

            Assert.True(result);

        }
        public void CheckIfWin_LettersRevealedValueIsNotWin_ReturnFalse()
        {
            Game game = new Game();

            game.revealedLetters = 1;

            bool result = game.isWin;

            Assert.False(result);


        }

        [Test]
        public void ValidInput_InputTwoLetters_ReturnFalse()
        {

            Game.guessedLetter = "WI";
            Game.correctWord = "WIN";

            bool result = Game.ValidInput;

            Assert.False(result);
        }

        [Test]
        public void ValidInput_InputLowerCase_ReturnTrue()
        {


            Game.guessedLetter = "w";
            Game.correctWord = "WIN";

            bool result = Game.ValidInput

            Assert.False(result);

        }
        
       
       
    }
}
