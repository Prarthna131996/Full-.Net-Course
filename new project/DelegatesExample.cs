using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
   public delegate void DelegateTestMethod(int a);
    public class DelegatesExample
    {
        public void Testmethod(int a)
        {
            Console.WriteLine(a);
        }
        public void Testmethod2(int b)
        { 
            Console.WriteLine(b);

        }
    }
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

      public delegate bool promotes(employee enums);
        public void promotemployee(List<employee> emplo , promotes iseligible)
        {
            foreach (employee emp in emplo)
            {
                if (iseligible(emp))
                {
                    Console.WriteLine(emp.Name + "Promoted");
                }
            }
        }


    }
    public class refandout
    {
        public void nummethod()
        {
            int i = 78;
            simplemethod(ref i);
            Console.WriteLine(i);
        }

        public void simplemethod( ref int j)
        {
            j = 100;
        }

        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sum (int a, params int[] b)
        {
            // a = 45;
            int result = 0;
            foreach (int i in b)
                result = result + i;
            Console.WriteLine( result);
        }

        public int PassMarks { get; } = 45;
    }

}      
