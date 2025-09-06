using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models.AuthUser;

namespace MainProgrammer


{
    class Program
    {
    static void Main(string[] args)
    
    {
        Console.WriteLine("Hello World!"); 
    // Create user1 AuthUser
        
         
        AuthUser user1 = new( 1, "mwamuziscodev", "MwaMuziCodeDev@gmail.com", "MwaMuzi Code Dev", "MwaMuzi", "Code Dev", "1234567890", true, true, false, false, DateTime.Now, DateTime.Now);

        Console.WriteLine(user1._UserId); 
    }

    
    
    }
}






