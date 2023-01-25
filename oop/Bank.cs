using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop
{
    public class Bank
    {
        private int id;
        private string name;
      
     
        private static string company ;
        private int age;
        private  static int count;

         static Bank() //static constructor
        {
            company = "TCS";
        }
        public Bank( string name, int age)
        {
           
            this.name = name;
            this.age = age;
            count++;
            id = count;
           


        }

        public string print()
        {
            return $"ID {id} Name {name} Age {age} Company {company}";
        }

        static void Main(string[] args)
        {
            Bank b1 = new Bank( "swapnil", 22);
            Console.WriteLine(b1.print());
            Bank b2 = new Bank( "sneha", 23);
            Console.WriteLine(b2.print());
            Bank b3 = new Bank("raj", 32);
            Console.WriteLine(b3.print());
        }





    }
  


   
}
