using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class PolymorphismParent
    {
        int a;
        int c;

        public PolymorphismParent(int a, int c)
        {
            this.a = a;
            this.c = c;
        }

        public void greet()
        {
            Console.WriteLine("Good Morning");
        }

        public virtual void study()
        {
            Console.WriteLine("read books");
        }

        public class Child : PolymorphismParent
        {
            public Child(int a,int c) : base(a, c)
            {
                this.a = a;
                this.c = c;
                
            }
            public override void study()
            {
                Console.WriteLine("read from videos");
            }

            public class child2 : PolymorphismParent
            {
                public child2(int a,int c) : base(a, c)
                {
                    this .a = a;    
                        this .c = c;
                }
                public override void study()
                {
                    Console.WriteLine("read from both");
                }

            }


            static void Main(string[] args)
            {
                PolymorphismParent pp = new PolymorphismParent(1,2);
                pp.study();
                Child c1=new Child(1,2);
                c1.study();
                child2 c2=new child2(1,2);
                c2.study();
                PolymorphismParent pp2=new Child(1,2);
                pp2.study();




            }

        }
    }
}
