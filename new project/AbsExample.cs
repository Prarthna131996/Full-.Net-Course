using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
     public abstract class AbsExample
    {
        public string Name { get; set; }
        public void Print()
        {

        }

        public abstract int Id { get; set; }
    }
    
    public class Quess : AbsExample
    {
        public override int Id { get; set; }
    }
}
