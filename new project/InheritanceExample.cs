using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
      public  class InheritanceExample
      { 
        public int color {  get; set; }

      }
    public class Childs : InheritanceExample
    {
        public string name { get; set; }
    }

    public class Grandchilds : Childs
    {
        public int numbers {  get; set; }
        

        
    }

    ///hierar/////

    public class ParentMethod
    {
        public void p()
        {
            Console.WriteLine("i am parent method");
        }
    }
        public class ChildMethod : ParentMethod 
        {
          public void c()
          {
                Console.WriteLine(" iam chid method");
          }
        }

    public class  ChildMethod2 : ParentMethod
    {
        public void c2()
        {
            Console.WriteLine(" i am child 2 method");
        }
    }

    public class GrandChild : ChildMethod
    { 
      public void g()
        {
            Console.WriteLine(" i am grand child method");
        }
    
    }
    public class GrandChild2 : ChildMethod2
    {
        public void g2()
        {
            Console.WriteLine(" i am grand2 child method");
        }

    }

    //method overriding //

    public class Couple
    {
        public Couple()
        {

        }
        static Couple()
        {
            

        }
        public virtual void A ()
            
        {   
            Console.WriteLine(" i am paretn method ");
        }
    }

    public class  Creek : Couple 
    {    public Creek()
        {

        }
        static Creek()
        {

        }
        public override void A()
        {
            Console.WriteLine(" i am child override method");
        }
    }

    public class Grovy : Creek
    {
        public Grovy()
        { 
        }
        static Grovy()
        {

        }
        public override void A()
        {
            Console.WriteLine(" i am grandchild override method");
        }
    }

    //method hiding

    public class apple
    {
        public int sum(int x, string y)
        {
            Console.WriteLine(y);
            Console.WriteLine(x);
            return 0;
        }
    }
        public class mangoes : apple
        {
            public new int sum(int x, int y)
            {
                int result = x + y;
               return result;
            }
            
               


        }

        public class Banana : mangoes
        { 
            public new int sum { get; set; }
        }
    


}
