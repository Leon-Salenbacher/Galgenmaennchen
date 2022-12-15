using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgenmaennchen.Service
{
    public class GameAdapter
    {
        public static int maxLetters = 5;

        public string getWord()
        {
            string word;
            int wordLength;

            //get word that fitt conditions
            do
            {
                //get word from api
                word = "ello";
                wordLength = word.ToCharArray().Length;
            } while (wordLength > maxLetters);
            return word;
        }
    }
}
