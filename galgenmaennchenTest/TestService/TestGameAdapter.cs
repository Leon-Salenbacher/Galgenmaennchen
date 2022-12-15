using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Galgenmaennchen.Service;

namespace galgenmaennchenTest.TestService
{
    [TestClass]
    public class TestGameAdapter
    {
        [TestMethod]
        public void Test_GetWord_goodcase01()
        {
            //proof if word is fitting 
            GameAdapter g = new GameAdapter();
            int epected_maxLength = GameAdapter.maxLetters;

            // assert
            string word = g.getWord();
            int actual_Length = word.ToCharArray().Length;
            Assert.AreEqual(epected_maxLength, actual_Length);
        }
    }
}
