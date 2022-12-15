using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Galgenmaennchen.Datenbank
{
    class APIConnectorcs
    {
        public static string HttpGet(string uri)
        {
            string content = null;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader sr = new StreamReader(stream))
            {
                content = sr.ReadToEnd();
            }

            return content;
        }
    }
}
