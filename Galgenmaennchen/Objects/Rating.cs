using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgenmaennchen.Objects
{
    class Rating
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int versuche;

        public int Versuche
        {
            get { return versuche; }
            set { versuche = value; }
        }

        private string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public Rating()
        {

        }

        public Rating(int versuche, string word)
        {
            this.versuche = versuche;
            this.word = word;
        }

        public Rating(int id, int versuche, string word)
        {
            this.versuche = versuche;
            this.word = word;
            this.id = id;
        }

    }
}
