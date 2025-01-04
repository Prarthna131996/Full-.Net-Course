using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class ConstructorExample
    {
        public int number;
        public string name;
        public string color;
        public int varint;
        public static int digit = 100;
        public ConstructorExample()
        {
            number = 100;
            name = "Rashi";
        }

        public ConstructorExample(int a , string b)
        {
            number = a;
            name = b;
        }

        public ConstructorExample(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }

        //public ConstructorExample(int g, string b)
        //{
        //    Console.WriteLine(g + b);
        //}

        //copy 

        public ConstructorExample(constructor user)
        {
            color = user.color;
            varint = user.varint;
        }

        //static constructor/
        static ConstructorExample()
        {
            Console.WriteLine("i am static constructor");
        }
    }

    public class StaticExample
    {

        public string name = "Rashi";
        public int Number(int a, int b)
        {
            return a + b;
        }

        public static string color { get; set; }

        public static void srik()
        {    
            
            Console.WriteLine("i am static method");
            color = "red";
           
        }   

        public void nums ()
        {
           
            Console.WriteLine(" i am non static method");
        }


       
    }




    
}





