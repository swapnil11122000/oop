using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public  class PropertySyntax
    {
         //property syntax
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }




        static void Main(string[] args)
        {
            PropertySyntax d1 = new PropertySyntax();
            // property initializer syntax
            d1.DeptId = 1;
            d1.DeptName = "HR";
            d1.Location = "Pune";

            // object initializer syntax
            PropertySyntax d2 = new PropertySyntax { DeptId = 2, DeptName = "Sales", Location = "Mumbai" };

        }
    }

}

