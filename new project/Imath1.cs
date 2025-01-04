using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public  interface Imath1
    {
        void sum();
        int sum2(int x, int y);

        int Sum3 { get; set; }

        void method1();
    }
    public interface Imath2
    {
        void test();
        void method1();
    }

    public class Monster
    {
        public int Sums { get; set; }
        void method1()
        {
            Console.WriteLine(" i am void method");
        }
    }
    public class Tempon : Monster,Imath1, Imath2
    {
        public void sum()
        {
            Console.WriteLine(" i am void sum method ");
        }

        public int sum2(int x, int y)
        {
            int result = x * y;
            return result;
        }
        public int Sum3 { get; set; }

        public void test()
        {
            Console.WriteLine(" i am test method");
        }

        public int sums {  get; set; }

        public void method1()
        {
            Console.WriteLine(" i am child void method 1");
        }

        //interface explicit//
        void Imath1.method1()
        {
            Console.WriteLine(" i am explicit i math method");
        }

        void Imath2.method1()
        {
            Console.WriteLine(" i am i math2 ");
        }
    }
}
