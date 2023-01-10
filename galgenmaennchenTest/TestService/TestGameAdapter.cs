using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Galgenmaennchen.Service;
using System.Threading.Tasks;

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

            Task<char[]> task = Task.Run<char[]>(async () =>
            await g.getWord());
            char[] wordArr = task.Result;

            // assert
            string word = new string(wordArr);
            int actual_Length = word.ToCharArray().Length;
            Assert.AreEqual(epected_maxLength, actual_Length);
        }
    }
}
