using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_C_Essential_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("admin","Vasya","Ivanov", 25);
            Console.WriteLine(user);

            User user2 = new User();
            //user2;
            user2.Login = "user2";
            Console.WriteLine(user2);

            Console.ReadKey();
        }
    }
}
