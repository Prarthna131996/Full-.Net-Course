using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public  abstract class Abstraction
    {
        public int count { get; set; }
        public void test1()
        {
        }
        public abstract string makesound(string x);
        
        
    }
    public class Dog : Abstraction
    { 
        public int count { get; set; }
        public void test1()
        {
            Console.WriteLine(" i am test 1 method");
        }
        public override string makesound(string x)
        {
            return x;
        }
    }
}
