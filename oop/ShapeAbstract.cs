using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    abstract public class ShapeAbstract
    { 
        public abstract void CalculateArea();
    }
    public class Circle1 : ShapeAbstract
    {
        private int radius;
        private double area;
        public Circle1(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of Circle is {area}";
        }

        public class Rectangle : ShapeAbstract
        {
            private int side1, side2;
            private double area;
            public Rectangle(int side1, int side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public override void CalculateArea()
            {
                area = side1 * side2;
            }
            public override string ToString()
            {
                return $"Area of Rectangleis {area}";
            }

            static void Main(string[] args)
            {
                Circle1 c1 = new Circle1(5);
                c1.CalculateArea();
                Console.WriteLine(c1);


                Rectangle r1 = new Rectangle(5, 5);
                r1.CalculateArea();
                Console.WriteLine(r1);
            }





        }




    }
}
