using new_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace news
{
    public class Modifiers1 : modifiers
    {  
        public void grrr()
        {
            base.varint4 = 1;
            Console.WriteLine(varint4);
            base.varint5 = 2;
            Console.WriteLine(varint5);
            
        }

    }

}
