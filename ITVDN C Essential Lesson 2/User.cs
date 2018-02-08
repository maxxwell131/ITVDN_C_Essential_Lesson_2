using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Задание 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе.  
*/

namespace ITVDN_C_Essential_Lesson_2
{
    class User
    {
        string login;
        string name;
        string lastName;
        uint age;
        readonly DateTime date;

        public User()
        {
            date = DateTime.Now;
        }

        public User (string login, string name, string lastName, uint age)
        {
            this.login = login;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            date = DateTime.Now;
        }

        public string Login
        {
            get { return login; }
            set {
                if(!String.IsNullOrEmpty(value)) 
                {
                    login = value;
                } else 
                {
                    Console.WriteLine("Login is empty !!!");

                }
            }

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name is empty !!!");

                }
            }

        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("lastName is empty !!!");

                }
            }

        }

        public uint Age
        {
            get { return age; }
            set
            {
                if (value > 25 && value < 70)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine(" age is out of range !!!");

                }
            }

        }

        public override string ToString()
        {
            string result = "Login: " + login + " Name: " + name + " Lastname: " + lastName + " age: " + age + " Date= " + date.ToLongDateString() + " &Time= " + date.ToLongTimeString();
            return result;
        }
    }
}
