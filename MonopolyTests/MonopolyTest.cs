﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonopolyKata
{
    [TestClass]
    public class MonopolyTest
    {
        private Monopoly monopoly = new Monopoly();
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;

        [TestInitialize]
        public void SetUp()
        {
            player1 = monopoly.GetPlayer(1);
            player2 = monopoly.GetPlayer(2);
            player3 = monopoly.GetPlayer(3);
            player4 = monopoly.GetPlayer(4);
        }
        [TestMethod]
        public void TestDistinctOrder()
        {
            Assert.AreEqual(10, monopoly.DistinctOrder());
        }

        [TestMethod]
        public void TestFullGame()
        {
            var player1Money = monopoly.GetPlayer(1).accountBalance;

            Assert.AreNotEqual(0, player1Money);
        }

        [TestMethod]
        public void TestMultiplierAccountFluctuationPlayer1()
        {
            var balanceBefore = player1.accountBalance;
            monopoly.RunMonopoly(3);
            var balanceAfter = player1.accountBalance;
            Assert.AreNotEqual(balanceBefore, balanceAfter);
        }

        [TestMethod]
        public void TestMultiplierAccountFluctuationPlayer2()
        {
            var balanceBefore = player2.accountBalance;
            monopoly.RunMonopoly(3);
            var balanceAfter = player2.accountBalance;
            Assert.AreNotEqual(balanceBefore, balanceAfter);
        }

        [TestMethod]
        public void TestMultiplierAccountFluctuationPlayer3()
        {
            var balanceBefore = player3.accountBalance;
            monopoly.RunMonopoly(3);
            var balanceAfter = player3.accountBalance;
            Assert.AreNotEqual(balanceBefore, balanceAfter);
        }

        [TestMethod]
        public void TestMultiplierAccountFluctuationPlayer4()
        {
            var balanceBefore = player4.accountBalance;
            monopoly.RunMonopoly(3);
            var balanceAfter = player4.accountBalance;
            Assert.AreNotEqual(balanceBefore, balanceAfter);
        }

    }
}
