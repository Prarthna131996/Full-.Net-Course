using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class CollectionExample
    {
        public void hastableexample()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "name");
            ht.Add(102, "age");
            ht.Add(103, "occuaption");
            ht.Add("abc", 23);

            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + "= " + i.Value);
            }
        }

        public void DictionaryExample()
        {
            Dictionary<string, int> dictNumber = new Dictionary<string, int>();
            dictNumber.Add("abc", 89);
            dictNumber.Add("xyz", 100);
            dictNumber.Add("def", 123);
            dictNumber.Add("pqr", 150);

            foreach (KeyValuePair<string, int> number in dictNumber)
            {
                Console.WriteLine(number.Key + "= " + number.Value);
            }

        }

        public void StackExample()
        {
            Stack stack = new Stack();
            stack.Push(667);
            stack.Push(89);
            stack.Push(90);
            stack.Push(104);
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void StackExample2()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("rupal");
            stack.Push("rashi");
            stack.Push("aditi");
            stack.Push("diya");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            string value = stack.Pop();

            Console.WriteLine("stack after pop");

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            string value1 = stack.Peek();
            //string value2 = stack.Peek();
            //string value3 = stack.Peek();
            //Console.WriteLine(" after peek :");
            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);

            //}
        }

        public void QueueExample()
        {
            Queue objQ = new Queue();
            objQ.Enqueue("56");
            objQ.Enqueue("yash");
            objQ.Enqueue(new DateOnly(2024, 10, 18));
            objQ.Enqueue("R");
            foreach (object o in objQ)
            {
                Console.WriteLine(o);
            }

            int num = Convert.ToInt32(objQ.Dequeue());
        }

        public void QueueExample2()
        {
            Queue<int> Queue = new Queue<int>();

            Queue.Enqueue(45);
            Queue.Enqueue(56);
            Queue.Enqueue(90);
            Queue.Enqueue(100);

            foreach (int item in Queue)
            {
                Console.WriteLine(item);
            }

            int num = Queue.Dequeue();
            Console.WriteLine("new :");
            foreach (int item in Queue)
            { Console.WriteLine(item); }
        }
    }
}
