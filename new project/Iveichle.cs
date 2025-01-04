using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public  interface Iveichle
    {
        
        void StartEngine()
        {
            Console.WriteLine("this is engiine");////////////default body

        }
        void StopEngine();

        int Wheels { get; set; }
        int Noofbox(int x, int y);

        void Testmethod();

    }
    public interface Icloud : Iveichle
    {
        int Memmory { get; set; }
        void Photos();
        void Testmethod();
      //  void StopEngine();  

    }
    public class Prize
    {
        public int Number { get; set; }
        public void Testmethod()
        {
            Console.WriteLine("i am t method");
        }

        
        
    }
    public class Car  :   Prize, Iveichle, Icloud
    {
        public void StartEngine()
        {
            Console.WriteLine(" car engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine("car engine stop");
        }
        public int Wheels { get; set; }
        
        public int Noofbox(int x, int y)
        {
            return  x * y;
        }
        public int Memmory { get; set; }
        public void Photos()
        {
            Console.WriteLine(" the photo gallery null");
        }

        public int Number { get;set; }

        public void Testmethod()
        {
            Console.WriteLine(" i am testmenthod");
        }

        /////////interface explicit method//
        
        void Iveichle.Testmethod()
        {
            Console.WriteLine(" I am iviechle explicit method");
        }
        void Icloud.Testmethod()
        {
            Console.WriteLine(" i am icar implcit method");
        }
    }
}
