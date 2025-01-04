using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class methodclass
    {
        //void method without parameter
        public void dox()
        {
            Console.WriteLine("it's my good practice");
        }

        //void method with parameter

       public void multiply(int a , int b)
        {
            int result = a * b;
          Console.WriteLine(result);
        }

        //return type with parameter

        public int divide(int a, int b)
        {
            int result = a / b;
            return result;
            Console.WriteLine(result);
        }

        //void type with array prameter

        public void sum(int[] ints)
        {
              int sum = 0;
            foreach(int i in ints) 
            {
                sum = sum + i;
            }
             Console.WriteLine(sum);

        }
        ///return type with array parameter
        public int sums (int[] array)
        {
            int result = 0;
            foreach (int i in array)
            

                result = result + i;
                

            
            return result;

        }

        ///array with parameter
        
        public int[] subs(int a, int b) 
        {
            int[] result = new int[2];
            result[0] = a;
            result[1] = b;
            return result;
        }

        //params array void
        public void xx (params int[]a)
        {
            int result = 0;
            foreach (int i in a) 
                result = result + i;
            Console.WriteLine(result);
        }

        //params with return type

        public int dums ( params int[]b)
        {
            int result = 0;
            foreach (int i in b)
                result = result + i;
            return result;
        }

    }




            

          

           

    }

