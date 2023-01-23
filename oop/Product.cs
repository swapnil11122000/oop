using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Product
    {
        public int prodid;
        public string prodname;
        public string company;
        public double price,disc;

        public Product(int prodid, string prodname, string company, int price)
        {
            this.prodid = prodid;   
            this.prodname = prodname;   
            this.company = company;
            this.price = price;
        }

        public void discount()
        {
            if (price > 2000)
            {
                disc = price*0.15;
            }
            else if (price < 2000)
            {
                disc= price*0.05;
            }
        }

        public string print()
        {
            return $"ProdictID:{prodid} ProductName:{prodname} Company:{company} Price:{price} Discount:{disc}";
        }

        static void Main(string[] args)
        {
            Product prod1 = new Product(21, "Bucket", "LG", 3000);
            prod1.discount();
            Console.WriteLine(prod1.print());
            Product prod2 = new Product(22, "Bucket2", "LG2", 1000);
            prod2.discount();
            Console.WriteLine(prod2.print());

        }






    }
}
