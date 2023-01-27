using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class OptionalAndDefaultParameter
    {
        private int userid;
        private string username;
        private bool isAdmin;

        // isAdmin is a default paramter
        public OptionalAndDefaultParameter(int userid, string username, bool isAdmin = false)
        {
            this.userid = userid;
            this.username = username;
            this.isAdmin = isAdmin;
        }
        public override string ToString()
        {
            return $"userid ={userid} , username ={username} admin={isAdmin}";
        }
        static void Main(string[] args)
        {
            //isAdmin is an optional parameter
            OptionalAndDefaultParameter user1 = new OptionalAndDefaultParameter(1, "Kishor");

            OptionalAndDefaultParameter user2 = new OptionalAndDefaultParameter(2, "Rajesh", true);

            Console.WriteLine(user1);
            Console.WriteLine(user2);

        }

    }
}
