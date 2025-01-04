using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class EnumsExaples
    {
        public string name { get; set; }
        public int gender { get; set; }

        public static string getgender(int gender)
        {
            switch (gender)
            {
                case 0:
                    {
                        return "unkonwn";

                    }
                case 1:
                    {
                        return "male";
                   
                    }

            case 2:
                    {
                        return "female";
                    }

                default:
                    {
                        return "invalid data";
                    }


            }

            
        }

    }

    public class Calculater

    {
        public bool value(int a, int b)
        {
            return a == b;

        }

    }
}
