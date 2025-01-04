using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class constructor
    {
        //set default value//
        public int varint;
        public bool varbool;
        public int number;
        public string color;
        public static int varint2;

        public constructor()
        {
            varint = 10;
            varbool = true;
        }
        /////method overloading ///////////

        public constructor(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);

        }

        public constructor(string a, int b, int c)
        {
            Console.WriteLine(a);
            int result = b + c;
            Console.WriteLine(result);
        }

        ///copy contructor//

        public constructor(constructor pk)
        {
             number = pk.number;
             color = pk.color;    
            

        }
        //static constructor//
        static constructor()
        {
            Console.WriteLine(" i am static constructor");
        }











    }
    /////old way
    public class way
    {
        public string _color;


        public string color { get { return _color; } set { value = _color; } }


        ///read only property

        public string clothes { get; } = "toppers";


    }
    
}
