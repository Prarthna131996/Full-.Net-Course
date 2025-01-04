using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class parent 
    {
        public parent()
        {
        }
        public void apple()
        {
            Console.WriteLine("i am parent method");
        }
    }

    public class child : parent
    {    public child() 
        { 
        }
        public void banana()
        {
            Console.WriteLine("i am child method");
        }
    }
    public class grandchild : child
    {
        public grandchild()
        {

        }
        public void pomo()
        {
            Console.WriteLine("i am grandchild method");
        }
    }
    ////HEIRARCHICAL INHERITANCE//////////

      public class parent1
      {
         public void parentmethod1()
         {
            Console.WriteLine("i am parent method");
         }
      }
    public class child1 :parent1
    {
        public void childmethod1()
        {
            Console.WriteLine("i am child method");
        }
    }
    public class child2 : parent1
    {
        public void childmethod2()
        {
            Console.WriteLine("i am child 2 method");
        }
    }
    public class grandchild1 : child1
    {
        public void grandchildmethod1()
        {
            Console.WriteLine("i am grandchild 1 method");
        }
    }
    public class grandchild2 : child2
    {
        public void grandchildmethod2()
        {
            Console.WriteLine("i am grandchild2 method");
        }
    }
}
