using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Galgenmaennchen.Service
{
    public class GameAdapter
    {
        public static int maxLetters = 5;
        public static string apiURL = "https://random-word-api.herokuapp.com/word?lang=de";
        static HttpClient client = new HttpClient();

        public async Task<char[]> getWord()
        {
            string word = null;
            char[] wordArr;

            //get word that fitt conditions
            do
            {
                //get word from api
                HttpResponseMessage response = 
                    await client.GetAsync(apiURL);
                if (response.IsSuccessStatusCode)
                {
                     word = await response.Content.ReadAsStringAsync();
                }

                wordArr = word.ToCharArray();
            } while (wordArr.Length > maxLetters);
            return wordArr;
        }
    }
}
