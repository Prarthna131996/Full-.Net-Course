using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    public class UserAlreadyLoggedIn : Exception
    {  
        
        
        
        public UserAlreadyLoggedIn() : base()
        {
        }
        public UserAlreadyLoggedIn(string message) : base(message)
        {
            
        }
    
    }
    public class Custom
    {   
        
        public void Test()
        
        {
            throw new UserAlreadyLoggedIn("user already logged in");
        }

       
    }
    
    
    
}
