using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class practice
    {
        public void TestMethod()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }


        ///////pass by value 

        //public static void fruits()
        //{
        //    int i = 10;
        //    {
        //        Console.WriteLine("before" + i);
        //    }

        //        veg(i);
        //    {
        //        Console.WriteLine("after {0} " , i);
        //    }


        //}
        //public static void veg(int num)
        //{
        //     num = 20;

        //    Console.WriteLine( "number inside function" + num); 
        //}

        //pass by ref 
        public static void fruits()
        {
            int i = 10;
            {
                Console.WriteLine("before" + i);
            }

            veg(ref i);
            {
                Console.WriteLine("after {0} ", i);
            }


        }
        public static void veg(ref int num)
        {
            num = 100;

            Console.WriteLine("number inside function" + num);
        }

        //out keyword 

        public void Method1()
        {
            int a = 55;
            Console.WriteLine("before" + a);
            Method2(a,out a);
            Console.WriteLine("after " + a);
        }

        public void Method2(int p,out int q)
        {
            q = 322;
            
            

            Console.WriteLine("after out " + p + q);
        }

        public void Num1(int x, params int[] y)
        {
            Console.WriteLine(x);
            foreach (int i in y)
            {
                Console.WriteLine(i);
            }
        }

        public int num2(int g, params int[] k)
        {
            Console.WriteLine(g);
            foreach(int i in k) 
                { Console.WriteLine(i); }
            return 0;

        }
    }
    public class circle
    {
        float x = 3.14f;
        int radious;

        public circle(int y)
        {
            radious = y;
        }

        public float Apple()
        {
            return x * radious * radious;

        }
    }

    //pass by value 

    public class Parameters()
    {
        //public void valuemethod()
        //{
        //    int i = 44;

        //    Console.WriteLine("before = {0} ", i);

        //    valuemethod2( ref i);
        //    {
        //       Console.WriteLine("before2 {0}" , i);
        //    }

        //}
        //public void valuemethod2( ref int a)
        //{
        //    a = 55;
        //    Console.WriteLine("after {0} ", a);
        //}

        public void valuemethod()
        {
            int i = 44;

            Console.WriteLine("before = {0} ", i);

            valuemethod2( i,i,out i);
            {
                Console.WriteLine("before2 {0}", i);
            }

        }
        public void valuemethod2( int p, int q , out int sum)
        {
            sum = p + q;
            Console.WriteLine("after {0} ", sum);
        }







    }
}
