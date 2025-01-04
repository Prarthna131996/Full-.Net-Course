using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class MethodExample
    {
        public void Number()
        {
            Console.WriteLine(" i am void method ");
        }

        public void Number2(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        public int Number3(int a, string b)
        {
            Console.WriteLine(b);
            return a;
        }

        public void arraynum(int[] ints)
        {
            foreach (int x in ints) { Console.WriteLine(x); }
        }
        public int Yuvi(int[] AR)
        {
            int result = 0;
            foreach (int x in AR)
                result = result + x;
            {
                Console.WriteLine(result);
            }
            return result;
        }
        public string[] Animal(string a, string b)
        {
            string[] animal = new string[2];
            animal[0] = a;
            animal[1] = b;
            return animal;

        }

        //params array

        public void num(string x, params int[] y)
        {
            Console.WriteLine(x);
            int result = 0;
            foreach (int w in y)
                result = result + w;
            {
                Console.Write(result);
            }

        }
        public int Nrew(string x, params int[] y)
        {
            Console.WriteLine(x);
            int result = 0;
            foreach (int hh in y)
                result = result + hh;
            {
                Console.Write(result);
            }
            return result;
        }
    }

    public class PropertyMethod
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public string Color { get; set; }

        public int Number { get; set; }


        public int Acclerator(int p)
        {
            int result = p * 10;
            return result;
        }
        public int Balance(int p)
        {
            int result = p / 10;
            return result;
        }



    }
    public class Ways
    {
        int _number;

        public int number
        {
            get { return _number; }
            set { _number = value; }


        }
        public int pro { get; } = 45;


        /////////method overliading

        public int Vox(int p, int q)
        {
            int result = p * q;

            return result;
        }
        public void Vox(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }


    }

    ////constructor

    
}
