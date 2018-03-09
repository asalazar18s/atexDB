using System;
using System.Collections.Generic;

namespace AtexDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Oli.");

            User Aaron;
            Aaron = new User("Aaron", "Oli", "admin");
            User Sharon;
            Sharon = new User("Sharon", "Italo", "nonadmin");
            List<User> Any;
            Any = new List<User> { Aaron, Sharon };
            UserController Edwin;

            Edwin = new UserController(Any);
            //String count;
            //int finder;
            //finder = Edwin.GetUser("Aaron");
            ////checker = Edwin.CheckClearance(Aaron);
            //Console.WriteLine(finder);
        }
    }
}
