using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    public class Employee
    {
        private  int empid;
        public string empname;
        public int salary;
        public int hra, pf, pt, da,total,netpaid;
        public static int count;
        public static string company ="TCS";
        public static double roi=9.2;
        /*public Employee()
        {
            company = "TCS";
            roi = 9.2d;

        }*/
        public Employee( string empname, int salary)
        {
          
            this.empname= empname;
            this.salary= salary;
        
            empid = count;
            count++;
        }
        public void Total()
        {
            hra = (salary / 100) * 40;
            pf = (salary / 100) * 20;
            da = (salary / 100) * 12;
            pt = 200;

            total = salary + hra + da;
            netpaid = total - (pf + pt);


        }
        public string Display()
        {
            return $"EmpId:{empid} EmpName:{empname} BasicSalary:{salary} TotalSalary:{total} NetPaid Salary:{netpaid} company:{company} ROI {roi}";

        }
        public static int Displaycount()
        {
            return count;
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee( "raj", 4000);
            emp.Total();
            Employee emp1 = new Employee("raj2", 3002);
            emp1.Total();
            Employee emp2 = new Employee("raj3", 3003);
            emp2.Total();
            Employee emp3 = new Employee("raj4", 3004);
            emp3.Total();
            Console.WriteLine(emp.Display());
            Console.WriteLine(emp1.Display());
            Console.WriteLine(emp2.Display());
            Console.WriteLine(emp3.Display());
            Console.WriteLine(Employee.Displaycount());



        }
        
    }
}
