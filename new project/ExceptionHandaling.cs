using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class ExceptionHandaling
    {
        public void TestMethod()
        {

            try
            {
                int a = 1000;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);


            }
            catch (Exception e)

            {
                Console.WriteLine("tere is some iss some issue plzz contact system" + e.Message);
                Console.WriteLine(e.StackTrace);

            }
            finally
            {
                Console.WriteLine(" the connection is broke ");
            }
        }

        public void TestMethod2(int a)
        {
            try
            {



                if (a < 0)
                {
                    throw new ArgumentException(" There is some issue ");
                }

                try
                {
                    int a1 = 90;
                    int b = 0;
                    int result1 = a1 / b;
                    Console.WriteLine(result1);
                }
                catch (Exception e)
                { 
                   // throw;
                   Console.WriteLine(e.Message);
                }
                int x = 190;
                int y = 0;
                int result = x / y;
                Console.WriteLine(result);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine(ex.StackTrace);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception e)

            {
                Console.WriteLine("there is some issue plzz contact the symstem" + e.Message);
                Console.WriteLine(e.StackTrace);


            }
            finally
            {
                Console.WriteLine("for some connection breakeee");
            }
        }


        

        
    }
}
