using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = projectA.TeamA;
using PATB = projectA.TeamB;

namespace projectA

{
    namespace TeamA
    {
        public class  ClassA
        {
            public static  void print()
            {
                Console.WriteLine("this team A METHOD ");
            }
        }



    }
}


namespace projectA

{
    namespace TeamB
    {
        public   class ClassA
        {
            public  static void print()
            {
                Console.WriteLine("this team B METHOD ");
            }
        }



    }
    
}

namespace Names
{
    public class ConstructorExamples
    {
        string firstname;
        string secondname;

        public ConstructorExamples()
        {
            firstname = "Rashi";
            secondname = " Gupta";
        }
    }
}

   