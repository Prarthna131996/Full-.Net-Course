using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class ExceptionHandlings
    {


        public void Method1()
        {
            try
            {
                Console.WriteLine("plz enter your first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your second number");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("result {0} = " + result);
            }

            catch (Exception ex)
            {
                Console.WriteLine("there is some error occcured " + ex.ToString());
                Console.WriteLine("contact the system " + ex.Message);
                Console.WriteLine("some error " + ex.StackTrace);
                Console.WriteLine("current exception " + ex.GetType());  
            }
           
        }

    }
}
