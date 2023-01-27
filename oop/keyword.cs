using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class keyword
    {

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Calculation( int a,int b,out int sum,out int sub,out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine($"value of a{a} b{b}");

            int sum, sub, mul;
            Calculation(a,b,out sum,out sub,out mul);
            Console.WriteLine($" sum:{sum} sub:{sub} mul{mul}");


        }


    }
}
