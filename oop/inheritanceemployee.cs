using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    public class inheritanceemployee
    {
        private int id;
        protected string name;

        protected double basic;
        private static int count;
        private double hra, da, ta, pf, gross;


        public inheritanceemployee(string name, double basic)
        {
            this.name = name;

            this.basic = basic;

            count++;
            id = count;
        }

        public virtual void calculatesalary()
        {
            hra = basic * 40;
            da = basic * 20;
            ta = basic * 10;
            pf = basic * 12;
            gross = (basic + hra + da + ta) - pf;

        }
        public string Employeedetails()
        {
            return $"Id {id} Name {name}  BaiscSalary {basic}  Gross {gross}";
        }





        public class Manager : inheritanceemployee
        {
            private double food, ma ,bonus=2000;
            // base keyword will call the base class constructor
            public Manager(string name, double basic ) : base(name, basic)
            {

            }
            public override void calculatesalary()
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                ta = basic * 0.10;
                pf = basic * 0.12;
                food = basic * 0.05;
                ma = basic * 0.12;
                gross = (basic + hra + da + ta + food ) - (pf + ma);
            }
            public string DisplayManagerDetails()
            {
                return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Manager ={gross} ";
            }
        }

        public class Salesperson : inheritanceemployee
        {
            private double bonus;
            public Salesperson(string name, double basic,double bonus) : base(name, basic)
            {
                this.bonus = bonus;

            }

            public override void calculatesalary()
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                ta = basic * 0.10;
                pf = basic * 0.12;
               
               
                gross = (basic + hra + da + ta + bonus) - (pf );
            }
            public override string ToString()
            {
                return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Manager ={gross} bonus {bonus}";
            }

        }
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Kishor", 41000);
            m1.calculatesalary();
            Console.WriteLine(m1.DisplayManagerDetails());


            inheritanceemployee e1 = new inheritanceemployee("Tushar", 27000);
             e1.calculatesalary() ;
            Console.WriteLine(e1.Employeedetails());

            Salesperson s1 = new Salesperson("raj", 35000,5000);
            s1.calculatesalary() ;
            Console.WriteLine(s1); //implicitly tostring gets called we dont need to specifically call method

        }



    }

}
