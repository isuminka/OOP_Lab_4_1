using System;

namespace OOP_Lab_4_1
{
    class Student
    {
        private string Name;
        private string LastName;
        private string Group;
        private int Year;
        private string Address;
        private string Passport;
        private int Age;
        private string Telephone;
        private int Raiting;

        public Student() { }

        public void StudentRaiting(int R)
        {
            if (R >= 90 && R <= 100) Console.WriteLine("Вiтаємо вiдмiнника!");
            else if (R >= 75 && R < 90) Console.WriteLine("Можна вчитися краще!");
            else if (R >= 0 && R < 75) Console.WriteLine("Варто бiльше уваги придiляти навчанню!");
            else Console.WriteLine("Неправильний бал!");
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string lastname
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }

        public string group
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }
        }

        public int year
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }

        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }

        public string passport
        {
            get
            {
                return Passport;
            }
            set
            {
                Passport = value;
            }
        }

        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }

        public string telephone
        {
            get
            {
                return Telephone;
            }
            set
            {
                Telephone = value;
            }
        }

        public int raiting
        {
            get
            {
                return Raiting;
            }
            set
            {
                Raiting = value;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Олег";
            st1.lastname = "Коваль";
            st1.group = "IКТА-11";
            st1.year = 2002;
            st1.address = "проспект Червоної Калини, 76";
            st1.age = 18;
            st1.telephone = "380736517850";
            st1.raiting = 87;

            Console.WriteLine("Iм'я: " + st1.name);
            Console.WriteLine("Прiзвище: " + st1.lastname);
            Console.WriteLine("Група: " + st1.group);
            Console.WriteLine("Рiк народження: " + st1.year);
            Console.WriteLine("Адреса: " + st1.address);
            Console.WriteLine("Вiк: " + st1.age);
            Console.WriteLine("Номер телефону: " + st1.telephone);
            Console.WriteLine("Рейтинг: " + st1.raiting);
            st1.StudentRaiting(st1.raiting);
        }
    }
}
