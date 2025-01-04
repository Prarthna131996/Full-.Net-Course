using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class car
    {
        //variables//
        public int varint;
        public string varstring = "rashi";

        //properties//

        public int noofseat { get; set; }
        public string color { get; set; }

        public string name { get; set; }


        ////methods///////

       public int Break(int pressure)
        {
            int result = pressure / 10;
            return result;
        }

        public int Clucth(int speed)
        {
            int result = speed;
            return result;
        }
            
            
        
    }
}
