using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class methodoverloading
    {
        public int addition(int a, int b)
        {
            return a + b;
        }
        public int addition(int a,int b,int c)
        {
            return a + b + c;

        }
        public double addition(double a, double b,double c)
        {
            return a + b + c;
        }
        public double addition(int a,double b,int c,double d)
        {
            return a + b + c + d;
        }

        static void Main(string[] args)
        {
            methodoverloading calc= new methodoverloading();
           
            Console.WriteLine(calc.addition(2, 3));
            Console.WriteLine(calc.addition(3,4,5));
            Console.WriteLine(  calc.addition(2.3,4,5));

        }
    }
}
