using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   /* public class employeeProperty
    {
        private int id;
        private string name;
        private int age;

        //property in c#
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        static void Main(string[] args)
        {
            employeeProperty emp1= new employeeProperty();
            emp1.id = 101;
            emp1.name = "Raj";
            emp1.Age = 10;
            Console.WriteLine($"{emp1.Name}  {emp1.Id}  {emp1.Age}");



        }


*/

    public class employeeProperty
    {
       
        public int age { get; set; }
        public string name { get; set; }

        public int salary { get; set; }
        static void Main(string[] args)
        {
            employeeProperty  emp1= new employeeProperty();
            emp1.age = 10;
            emp1.salary = 20;
            emp1.name = "raj";
            Console.WriteLine($"{emp1.name}{emp1.age}{emp1.salary}");
        }

    }


    }



