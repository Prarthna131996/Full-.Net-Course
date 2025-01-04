using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class modifiers
    {
        public int varint = 111;
        private int varint2 = 45;
        internal int varint3 = 789;
        protected int varint4 = 654;
        protected internal int varint5 = 00;
        private protected int varint6 = 87;
    }

    public class num : modifiers
    {
        public void nummethod()
        {
            base.varint4 = 65;
            Console.WriteLine(varint4);
            base.varint5 = 90;
            Console.WriteLine(varint5);
            base.varint6 = 55;
            Console.WriteLine(varint);
          
        }
        
    }
}
