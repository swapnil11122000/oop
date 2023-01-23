using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Student // variables ,constructor,method,property,indexer,event
    {
        //variables or data members
        private int rollno;
        private string name;
        private int maths, eng, hin,total;
        private double percentage;
        public Student()
        {
            rollno = 1;
            name = "Test";
            eng = 0;
            hin = 0;
            maths = 0;

        }

        public Student(int rollno, string name, int eng, int hin, int maths)
        {
            this.rollno = rollno; // this keyword points to the data member
            this.name = name;
            this.eng = eng;
            this.hin = hin;
            this.maths = maths;
        }
        public void Calculation()
        {
            total = eng + hin + maths;
            percentage = (double)total / 3;
        }

        public string Display()
        {
            return $"Roll No {rollno} name {name} total ={total} percentage= {percentage}";
        }

        static void Main(string[] args)
        {
            //create object of student class
            Student stud = new Student(101, "Suraj", 78, 68, 87);
            stud.Calculation();
            Console.WriteLine(stud.Display());
        }


    }
}
