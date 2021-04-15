using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }
        protected string University { get; set; }
        protected string Speciality { get; set; }
        protected int Course { get; set; }
        public static string name()

        {
            string name;
            bool k = false;
            do
            {
                k = false;
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите имя и фамилию");
                    name = Console.ReadLine();
                }
                string name2 = name;
                for (int i = 0; i < name2.Length; i++)
                {
                    while (name2[i] < 'A' || (name2[i] > 'Z' && name2[i] < 'a') || name2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Только латиница");
                        k = true;
                        break;
                    }
                }
            } while (k);
            return name;
        }
  
        public static int age()
        {
            string age1;
            int Age1;
            do
            {
                age1 = Console.ReadLine();
                if (!int.TryParse(age1, out Age1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToInt32(age1) < 16)
                {
                    Console.WriteLine("Такой возраст не возможен");
                }
                else if (Convert.ToInt32(age1) > 100)
                {
                    Console.WriteLine("Такой возраст не возможен");
                }
                else break;
            } while (true);
            return Age1;
        }
        public static double weight()
        {
            string weight1;
            double Weight1;
            do
            {
                weight1 = Console.ReadLine();
                if (!double.TryParse(weight1, out Weight1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToDouble(weight1) < 40)
                {
                    Console.WriteLine("Невозможный вес");
                }
                else if (Convert.ToDouble(weight1) > 450)
                {
                    Console.WriteLine("Невозможный вес");
                }
                else break;
            } while (true);
            return Weight1;
        }
        public static double height()
        {
            string height1;
            double Height1;
            do
            {
                height1 = Console.ReadLine();
                if (!double.TryParse(height1, out Height1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToDouble(height1) < 0.50 || Convert.ToDouble(height1) > 2.50)
                {
                    Console.WriteLine("Такой рост невозможен");
                }
                else break;
            } while (true);
            return Height1;
        }
        public static string university()
        {
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ещё раз");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Только латиница");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);
            string[] String2 = university.Split(' '); 
            for (int i = 0; i < String2.Length; i++)
            {
                if (String2[i] != "")
                {
                    Console.Write(String2[i] + " ");
                }
            }
            Console.WriteLine();
            return university;
        }
        public static int course()
        {
            int course;
            string Course;
            do
            {
                Course = Console.ReadLine();
                if (!int.TryParse(Course, out course))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToInt32(Course) < 1 || Convert.ToInt32(Course) > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Невозможно");
                    Console.WriteLine("Введите ещё раз");
                }
                else break;
            } while (true);
            return course;
        }
        public void show()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " +
              Height + "\nUniversity: " + University + "\nCourse: " + Course + "\nSpecialty: " + Speciality + "\n");
        }
        public void rename0(ref string name1)
        {
            Console.WriteLine("Напишите новое имя");
            bool k = false;
            do
            {
                k = false;
                while ((name1 = Console.ReadLine()).Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите имя");
                    name1 = Console.ReadLine();
                }
                string name2;
                name2 = name1;
                for (int i = 0; i < name2.Length; i++)
                {
                    while (name2[i] < 'A' || (name2[i] > 'Z' && name2[i] < 'a') || name2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Только латиница");
                        k = true;
                        break;
                    }
                }
            } while (k);
        }
        public void rename(ref string name1)
        {
            rename0(ref name1);
            Name = name1;
        }
        public void resurname()
        {
            Console.WriteLine("Введите новую фамилию");
            string name1;
            bool k = false;
            do
            {
                k = false;

                while ((name1 = Console.ReadLine()).Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите фамилию");
                    name1 = Console.ReadLine();
                }
                string name2;
                name2 = name1;
                for (int i = 0; i < name2.Length; i++)
                {
                    while (name2[i] < 'A' || (name2[i] > 'Z' && name2[i] < 'a') || name2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Только латиница");
                        k = true;
                        break;
                    }
                }
            } while (k);
            Surname = name1;

        }
    
        public void Reage()
        {
            Console.WriteLine("Age:");
            string age1;
            int Age1;
            do
            {
                age1 = Console.ReadLine();
                if (!int.TryParse(age1, out Age1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToInt32(age1) < 16)
                {
                    Console.WriteLine("Такой возраст невозможен");
                }
                else if (Convert.ToInt32(age1) > 100)
                {
                    Console.WriteLine("Такой возраст невозможен");
                }
                else break;
            } while (true);
            Age = Convert.ToInt32(age1);
        }
        public void Reweight()
        {
            Console.WriteLine("Weight: ");
            string weight1;
            double Weight1;
            do
            {
                weight1 = Console.ReadLine();
                if (!double.TryParse(weight1, out Weight1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToDouble(weight1) < 40)
                {
                    Console.WriteLine("Такой вес невозможен");
                }
                else if (Convert.ToDouble(weight1) > 450)
                {
                    Console.WriteLine("Такой вес невозможен");
                }
                else break;
            } while (true);
            Weight = Convert.ToDouble(weight1);
        }
        public void Reheight()
        {
            Console.WriteLine("Height: ");
            string height1;
            double Height1;
            do
            {
                height1 = Console.ReadLine();
                if (!double.TryParse(height1, out Height1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToDouble(height1) < 0.50 || Convert.ToDouble(height1) > 2.50)
                {
                    Console.WriteLine("Такой рост невозможен");
                }
                else break;
            } while (true);
            Height = Convert.ToDouble(height1);
        }
        public void Reuniversity()
        {
            Console.WriteLine("University: ");
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ещё раз");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Только латиница");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);

            string[] String2 = university.Split(' '); 
            for (int i = 0; i < String2.Length; i++)
            {
                if (String2[i] != "")
                {
                    Console.Write(String2[i] + " ");
                }
            }
            Console.WriteLine();
            University = university;
        }
        public void Recourse()
        {
            Console.WriteLine("Course: ");
            int course;
            string Course1;
            do
            {
                Course1 = Console.ReadLine();
                if (!int.TryParse(Course1, out course))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToInt32(Course1) < 1 || Convert.ToInt32(Course1) > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Невозможно");
                    Console.WriteLine("Введите ещё раз");
                }
                else break;
            } while (true);
            Course = Convert.ToInt32(Course);
        }
        public void Respeciality()
        {
            Console.WriteLine("Speciality: ");
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ещё раз");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Только латиница");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);

            string[] String2 = university.Split(' ');
            for (int i = 0; i < String2.Length; i++)
            {
                if (String2[i] != "")
                {
                    Console.Write(String2[i] + " ");
                }
            }
            Console.WriteLine();
            Speciality = university;
        }
        public Student()
        {
            Console.WriteLine(" Введите имя: ");
            Name = Student.name();
            Console.WriteLine("Введиье фамилию: ");
            Surname = Student.name();
            Console.WriteLine("введите возраст: ");
            Age = Student.age();
            Console.WriteLine("введите вес: ");
            Weight = (int)Student.weight();
            Console.WriteLine("Введите рост: ");
            Height = (int)Student.height();
            Console.WriteLine("Введите название вуза: ");
            University = Student.university();
            Console.WriteLine("Введите название курса: ");
            Course = Student.course();
            Console.WriteLine("Введите свою специальность: ");
            Speciality = Student.university();
        }
    }
    class Program
    {
        public static string name1;

        static void Main(string[] args)
        {
            Student st = new Student();
            bool N = false;
            char digit;
            Console.Clear();
            while (N == false)
            {
                Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n" +
                    "4.Change age.\n5.Change weight.\n6.Change university.\n7.Chnge speciality.\n8.Change the course.\na.Change height.\n0. Exist\n");
                digit = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (digit)
                {
                    case '1': st.show(); break;
                    case '2': st.rename(ref name1); break;
                    case '3': st.resurname(); break;
                    case '4': st.Reage(); break;
                    case '5': st.Reweight(); break;
                    case '6': st.Reuniversity(); break;
                    case '7': st.Respeciality(); break;
                    case '8': st.Recourse(); break;
                    case 'a': st.Reheight(); break;
                    case '0': N = true; break;
                    default: break;
                }
            }
        }
    }
}


   

