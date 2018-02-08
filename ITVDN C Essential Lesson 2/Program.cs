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
            user2.Login = "user2";
            user2.Name = "";
            user2.LastName = "Stepanov";
            user2.Age = 102;
            Console.WriteLine(user2);

            Console.ReadKey();
        }
    }
}
