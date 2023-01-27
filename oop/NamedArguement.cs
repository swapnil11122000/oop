using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class NamedArguement
    {
        private int deptid;
        private string deptname;
        private string location;

        public NamedArguement(int deptid, string deptname, string location)
        {
            this.deptid = deptid;
            this.deptname = deptname;
            this.location = location;
        }
        static void Main(string[] args)
        {
             NamedArguement d1 = new NamedArguement(1, "HR", "Pune");
            // named argument
            NamedArguement d2 = new NamedArguement(location: "Mumbai", deptname: "Sales", deptid: 2);

            NamedArguement d3 = new NamedArguement(deptid: 3, deptname: "Admin", location: "Pune");

        }
    }
}
