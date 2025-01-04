using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class Parent
    {
        public Parent()
        { 
        }
       static Parent()
        { }
        public virtual void parentmethod()
        {
            Console.WriteLine(" i am parent method");

        }
        
    }
    public class Child : Parent
    {    public Child()
        { }
        static Child() { }
        public override void parentmethod()
        {
            Console.WriteLine("i am child override method");
        }
    }
    public class Grandchild : Child
    {
        public Grandchild()
        { }
        static Grandchild()
        { }
        public override void parentmethod()
        {
            Console.WriteLine("i am grandchild override method");
        }
    }

    public class mango
    {
        public void mangomethod()
        {
            Console.WriteLine(" i am mango method");
        }
    }

    public class lichi   : mango
    {
        public new void lichimethod()
        {
            Console.WriteLine(" i am lichi method");
        }
    }

    public class kiwi   : lichi
    {
        public new void kiwimethod()
        {
            Console.WriteLine("i am kiwi method");
        }
    }











}


