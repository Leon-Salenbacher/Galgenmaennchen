using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgenmaennchen.Objects
{
    class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {

        }

        public User(String name, String password, int Id)
        {
            this.name = name;
            this.password = password;
        }
        public User(int id, String name, String password, int Id)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }

    }
}
