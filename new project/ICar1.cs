using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public interface ICar1
    {
        void Test1();
        string Name { get; set; }
        int Sum(int x, int y);


    }

    public class T : ICar1
    {
        public void Test1()
        {
            Console.WriteLine("i am test method");
        }

        public string Name { get; set; }

        public int Sum(int x, int y)
        {
            int result = x + y;
            return result;  
        }
    }

    public interface Custmer
    {
        void Method();
        int Method2 { get; set; }
    }

    public interface Custmer1 : Custmer 
    {
        int Number(int x);

    }
    public class Cars : Custmer1
    {
        public void Method()
        {
            Console.WriteLine("i am void method ");
        }
        public int Method2 { get; set; }

        public int Number(int x)
        {
            return x;
        }
    }

    public interface Bus
    {
        void Method();
    }
    public interface Bus2
    {
        void Method();
    }

    public class Veichle : Bus, Bus2
    {
        public void Method()
        {
            Console.WriteLine(" i am interface one Method");
        }

        void Bus.Method()
        {
            Console.WriteLine(" i am one more interface method ");
        }

        void Bus2.Method()
        {
            Console.WriteLine(" i am inter face 2 method ");
        }
    }

}
