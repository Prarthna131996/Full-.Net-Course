using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class CExamples
    {
        string FirstName;
        string LastName;
       public  static string color;

        public CExamples(string a, string b)
        {
            FirstName = a;
            LastName = b;

        }

        public void FullName()
        {
            Console.WriteLine("fullname = {0}{1} ", FirstName, LastName);
        }

        ~CExamples()
        {
            //clean up code 

        }

		static CExamples()
		{
			Console.WriteLine("i m s c ");
		}

        public CExamples(CExamples a)
        {
            FirstName = a.FirstName;
            LastName = a.LastName;
        }
	}
    public class Luv
    {
        float Pi = 3.14f;
        int Radious;

        public Luv(int radious)
        {
            Radious = radious;
        }

        public float totalarea()
        {
            return Pi * Radious * Radious;
        }



    }
    public class Employee()
    {
      public string FirstName;
        public string LastName;
        public string Email;

        public void FullName()
        {
            Console.WriteLine("fullname = {0} {1} " , FirstName, LastName);
        }
        
    }
    public class FullEmployee : Employee
    {
        public int Yearly;
    }

    public class PartEmployee : Employee
    {
        public int hourly;
    }
    public class baseclass
    {
        public void BaseMethod()
        {
            Console.WriteLine("i am base method");
        }
    }

    public class ChildBase : baseclass
    {
        public new void BaseMethod()
        {
            Console.WriteLine("i am child base method");
        }
    }
    public class grandbase : ChildBase 
    {
        public new void basemethod()
        {
            Console.WriteLine("i am grand base method");
        }
    }

    public class b
    {
        public virtual void Method()
        {
            Console.WriteLine("i am parent method");
        }
    }
     public class c : b
     {
        public override void Method() 
        {
            Console.WriteLine("i am child override method");
        }

     }
    public class g : c
    {
        public override void Method()
        {
            Console.WriteLine(" i am grand child override method");
        }
    }
}
