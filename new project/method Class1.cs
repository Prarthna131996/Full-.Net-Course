using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    class methodClass1
    {
        ////////////method with no parameter\\\
        public void number()
        {
            Console.WriteLine("i am no parameter");
        }

        //method with paramerter//
        public void value(int x , int y)
        { 
            int result = x + y;
            Console.WriteLine(result);
        
        }

        //method with return type//
        public string num(string a , string b)
        {
            string result = a + b;  
           Console.WriteLine(result);
            return result;
        }
        
        ///araay with no return type//
        
        public void apple(int[] ints)
        {
            int result = 0;
            foreach (int i in ints)
                result += i;    
                Console.WriteLine(result);
        }

        ///array with return type//
        public string mangoes(string[] ints1)
        {
            string result = null;
            foreach (string i in ints1)
                result += i;
            return result;
        }   
          
        public int pine(int[]lemon)
        {
            int result = 0;
            foreach(int i in lemon)
                result += i;
            return result;
        }
         
        //one more aaray value showing//
        public string[] fruits (string x , string y , string z)
        {
            string[] strings = new string[3];
            strings[0] = x;
            strings[1] = y;
            strings[2] = z;
            return strings;

        }

        //params aaray without return type//

        public void banana(int s,params string[] fruits)
        {
            string result = null;
            foreach(string fruit in fruits)
                result += fruit;
            Console.WriteLine(result);
            Console.WriteLine(s);
        }
        
       //with return type//
       public int blows(string x , params int[] ints)
        {
            Console.WriteLine(x);
            int result = 0;
            foreach( int i in ints) 
                result += i;
            return result;
            
            
        }

        ////////method overloading
        
        public int varint (int a, int b)
        {   

            int result = a+b;
            return result;
            
        }
        public int varint(string a, int b)
        {   
            
            string result = a;
            Console.WriteLine(result);
            int result2 = b;
            Console.WriteLine(result2);
            return result2;

        }

        public int digi(  int a, int b)
        {    
          //  Console.WriteLine("plzz enter your number");
           // a = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("enter your second number");
           // b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your action to perform");
           string action = Console.ReadLine();
            int result = 0;
            if (action == "sum")
            {
                result = a + b;
            }
            else if (action == "subtract")
            {
                result = a- b;
            }
            else if (action == "multiply")
            {
                result = a * b;
            }
            else if (action =="divide")
            {  result = a / b; }
            return result;
            
        }
        
    }  
}
