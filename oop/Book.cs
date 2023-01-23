using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Book
    {
        public string authorname;
        public string bookname;
        public int price;

        public Book()
        {
            authorname = "shivaji sawant2";
            bookname = "Chava2";
            price = 40002;
        }

        public void Accept(string authorname,string bookname,int price)
        {
            this.authorname= authorname;
            this.bookname= bookname;
            this.price= price;
        }
        public string Dispaly()
        {
            return $"AuthorName:{authorname} BookName:{bookname} Price:{price}";
        }

        static void Main(string[] args)
        {
            Book boo=new Book();
            boo.Accept("Shivaji Sawant", "Chava", 5000);
            string result = boo.Dispaly();
            Book boo2 = new Book();
            string result2 = boo2.Dispaly();
            Console.WriteLine(result2);
            Console.WriteLine(result);

          /*  Employee emp = new Employee();
            emp.Accept(21, "Raj", 50000);
            string result1 = emp.Display();
            Employee emp2 = new Employee();
            string result3 = emp2.Display();
            Console.WriteLine(result3);
            Console.WriteLine(result1);*/
        }






    }
}
