using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace new_project
{
    public  class CollectionExampless
    {
        public void Animals()
        {
          ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("you");
            arrayList.Add(true);
            arrayList.Add('A');
            arrayList.Add(DateTime.Now);
            arrayList.Add(6.11);

            int value1 = Convert.ToInt32(arrayList[0]);
            string value2 = Convert.ToString (arrayList[1]);
            bool value3 = Convert.ToBoolean (arrayList[2]);
            char value4 = Convert.ToChar (arrayList[3]);
            DateTime value5 = Convert.ToDateTime (arrayList[4]);
            decimal value6 = Convert.ToDecimal (arrayList[5]);

            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //insert values//

            arrayList.Insert(3, "Kartik");
            string value7 = Convert.ToString (arrayList[6]);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //update //

            arrayList[5] = 3.14;

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //delete//

            arrayList.Remove(3.14);
            arrayList.RemoveAt(1);

            Console.WriteLine(" after deleting values ");
           
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            int size = arrayList.Count; 
            Console.WriteLine(" the size of arraylist list is as : " + size);

            bool isexist = arrayList.Contains(100);
            Console.WriteLine("the bool value is  :: " + isexist ); 

        }

        public void Parrot()
        {    
           Hashtable hashtable = new Hashtable();
            hashtable.Add(1001 ,90);
            hashtable.Add(1002, "flowers");
            hashtable.Add("a" , true);
            hashtable.Add("b" , DateTime.Now);

            int num1 = Convert.ToInt32(hashtable[1001]);
            String num2 = Convert.ToString(hashtable[1002]);
            bool num3 = Convert.ToBoolean(hashtable["a"]);
            DateTime num4 = Convert.ToDateTime(hashtable["b"]);

            //foreach(DictionaryEntry i in hashtable)
            //{
            //    Console.WriteLine(i.Key + "="  + i.Value);
            //}

            //update data//
            hashtable[1002] = "Like flower";

            //foreach (DictionaryEntry i in hashtable)
            //{
            //    Console.WriteLine(i.Key + "=" + i.Value);
            //}

            //delete//
            hashtable.Remove("1002");

            foreach (DictionaryEntry i in hashtable)
            {
                Console.WriteLine(i.Key + "=" + i.Value);
            }

            int count = hashtable.Count;
            Console.WriteLine(" the count is : " + count);
            bool value = hashtable.Contains(100);
            Console.WriteLine("the bool value is : " + value);  
             bool value2 = hashtable.ContainsKey("a");
            Console.WriteLine("the bool value is " + value2);

        }

        public void Diwali()
        {
            Stack objStack = new Stack();
            objStack.Push(98);
            objStack.Push("happy diwali");
            objStack.Push(true);
            objStack.Push(DateTime.Now);

            //foreach (object i in objStack)
            //{
            //    Console.WriteLine(i);
            //}

            DateTime val1 = Convert.ToDateTime(objStack.Peek());
            DateTime val2 = Convert.ToDateTime(objStack.Peek());
            DateTime val3 = Convert.ToDateTime(objStack.Peek());
            DateTime val7 = Convert.ToDateTime(objStack.Pop());
            //DateTime val4 = Convert.ToDateTime(objStack.Peek());


            //DateTime n1 = Convert.ToDateTime(objStack.Pop());
            //bool n2 = Convert.ToBoolean(objStack.Pop());
            //string n3 = Convert.ToString(objStack.Pop());
            //int n4 = Convert.ToInt32(objStack.Pop());




            foreach (object i in objStack)
            {
                Console.WriteLine(i);
            }



        }

        public void Christmis()
        {
            Queue objQueue = new Queue();

            objQueue.Enqueue("operation");
            objQueue.Enqueue(65);
            objQueue.Enqueue(45.6);

            //foreach(object j in objQueue)
            //{
            //    Console.WriteLine(j);
            //}

            string o1 = Convert.ToString(objQueue.Peek());
            string o2 = Convert.ToString(objQueue.Peek());
            string o3 = Convert.ToString(objQueue.Peek()); 
            string o4 = Convert.ToString(objQueue.Peek());


            foreach (object j in objQueue)
            {
                Console.WriteLine(j);
            }

            string p1 = Convert.ToString(objQueue.Dequeue());
            int p2 = Convert.ToInt32(objQueue.Dequeue());
            decimal p3 = Convert.ToDecimal(objQueue.Dequeue());

            

        }
    }
}
