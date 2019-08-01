using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceGame;
using static SpaceGame.Enumerations;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestPlayerTokens()
        //{
        //    Player player = new Player(4500);
           
        //   Assert.AreEqual(4500, player.Tokens);
        //}

        [TestMethod]
        public void TestPlayerBuyFail()
        {
            Player player = new Player();
            Product product = new Product {Price = 50, ProductType = ProductTypes.Clothes};
            bool succeeded = player.Buy(product);
            Assert.IsFalse(succeeded);

        }
        [TestMethod]
        public void TestPlayerBuySucceed()
        {
            Player player = new Player(4500);
            Product product = new Product { Price = 50, ProductType = ProductTypes.Clothes };
            bool succeeded = player.Buy(product);
            Assert.AreEqual(4450, player.Tokens);

        }
    }
}
