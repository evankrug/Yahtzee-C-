using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Yahtzee_game;



namespace TestYahtzee.UnitTests
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void RollDieTest()
        {
            Die die = new Die();
            int roll = die.RollDie();
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 6);


        }
    }
}
