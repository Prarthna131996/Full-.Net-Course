using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public abstract class AbstactionExample
    {
        public void TestMethod()
        {
            Console.WriteLine(" i am test method ");
        }
        public abstract int Money(int x, int y);

    }
    public abstract class AbstactionExample2
    {
        public void TestMethod()
        {
            Console.WriteLine(" i am test method ");
        }
        public abstract int Money(int x, int y);
    }

    public class Nuetral
    {

        public void TestMethod3()
        {
            Console.WriteLine(" ttttttttt");
        }


        public class ClassMethod : AbstactionExample
        {
            public override int Money(int x, int y)
            {
                int result = x * y;
                return result;
            }

            public void TestMethod2()
            {
                Console.WriteLine(" i am t method");
            }
            public void TestMethod3()
            {
                { Console.WriteLine("ttttttttttt"); }
            }
        }
    }
}
