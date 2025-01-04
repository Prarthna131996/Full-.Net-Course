using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class genricexample
    {
        public void testmethod()
        {
            List<string> list = new List<string>();
            list.Add("rashi");
            list.Add("rupal");
            list.Add("hemant");
            list.Add("jai");

            //foreach (var item in list) 
            //{Console.WriteLine(item); }

            list.Insert(2, "geeta");
            list[3] = "pritty";
            //foreach (var item in list)
            //{ Console.WriteLine(item); }

            list.Remove("jai");
            foreach (var item in list)
            { Console.WriteLine(item); }


            int count = list.Count;
            Console.WriteLine("the count of arraylist is " + count);

            bool isv = list.Contains("rupal");
            Console.WriteLine("the bool value is " + isv);




        }
        public void testmethod2()
        { 
            Dictionary<int,string> objA = new Dictionary<int, string>();

            objA.Add(1, "rashi");
            objA.Add(2, "vedant");
            objA.Add(3, "neil");
            objA.Add(4, "kiara");

            //foreach(var item in objA)
            //{ Console.WriteLine(item); }

            foreach(KeyValuePair <int,string>i in objA)
            {
                Console.WriteLine(i.Key + "=" + i.Value);

            }
            objA[4] = "aadvani"; 

        }

        public void testMthod3()
        {
            Stack <int> ints = new Stack<int>();    
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }

            
        }

        public void testmethod4()
        {
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
