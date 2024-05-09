using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student First task

            Studentl stud1 = new Studentl("22531");
            Console.WriteLine(stud1.PrintS());

            Studentl stud2 = new Studentl("1516","Ali");
            Console.WriteLine(stud2.PrintS());

            Studentl stud3 = new Studentl("1651615","khaled",33);
            Console.WriteLine(stud3.PrintS());



            Studentl stud = new Studentl();
            Console.WriteLine(stud.PrintS());


            Console.WriteLine($"\nEnetr data of student :");
            Console.WriteLine($"Enetr ssn :");
            stud.Ssn = Console.ReadLine();

            Console.WriteLine($"Enetr name :");
            stud.Name = Console.ReadLine();

            do
            {
                try
                {
                    Console.WriteLine("Enter Student age:");
                    stud.Age=int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (stud.Age < 18 || stud.Age > 45);

            //Console.WriteLine($"Enetr age :");
            //stud.SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Enetr address :");
            stud.Address=Console.ReadLine();

            Console.WriteLine(stud.PrintS());


            int num3 = 0;
            do
            {
                try
                {
                    Console.WriteLine("\nenter number of Student : ");
                    num3 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (num3 < 1);
            int counter=0;
            Studentl[] studarr = new Studentl[num3];
            for (int i = 0; i < studarr.Length; i++)
            {
                try
                {
                    studarr[i] = new Studentl();
                    if (counter > 0)
                    {
                        if (counter % 10 == 0) Console.WriteLine($"/*/*/*/*/*/*/*/*/*/*/*you entered {counter} Students*/*/*/*/*/*/*/*/*/*/*/*");
                    }
                    Console.WriteLine($"Enetr data of student {i + 1} :");
                    counter++;
                    Console.WriteLine($"Enetr ssn :");
                    studarr[i].Ssn = Console.ReadLine();

                    Console.WriteLine($"Enetr name :");
                    studarr[i].Name = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.WriteLine("Enter Student age:");
                            studarr[i].Age = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (studarr[i].GetAge() < 18 || studarr[i].GetAge() > 45);

                    //Console.WriteLine($"Enetr age :");
                    //studarr[i].SetAge(int.Parse(Console.ReadLine()));

                    Console.WriteLine($"Enetr address :");
                    studarr[i].Address = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            for (int i = 0; i < studarr.Length; i++)
            {
                Console.WriteLine(studarr[i].PrintS());
            }
            #endregion


            #region Student
            Person person = new Person();


            inhert.Student student2 = new inhert.Student("12");
            Console.WriteLine(student2.PrintStu());

            inhert.Student student3 = new inhert.Student("12", "nour");
            Console.WriteLine(student3.PrintStu());

            inhert.Student student4 = new inhert.Student("12", "nour", "Ali");
            Console.WriteLine(student4.PrintStu());

            inhert.Student student5 = new inhert.Student("12","nour","Ali","Alex",25,"first","second");
            Console.WriteLine(student5.PrintStu());

            inhert.Student student = new inhert.Student();
            Console.WriteLine(student.PrintStu());

            int num1 = 0;
            do
            {
                try
                {
                    Console.WriteLine("\nenter number of Students : ");
                    num1 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (num1 < 1);

            inhert.Student[] student1 = new inhert.Student[num1];

            for(int i =0;i< student1.Length;i++)
            {
                //string _id, string _fname, string _lname, string _address, int _age, string _schoolyear, string _class
                Console.WriteLine($"enter Student {i+1} id :");
                string x = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} First name :");
                string y = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Last name :");
                string a = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Address :");
                string b = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Age :");
                int q = int.Parse(Console.ReadLine());

                Console.WriteLine($"enter Student {i + 1} SchoolYear :");
                string r = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Class :");
                string p = Console.ReadLine();

                student1[i] = new inhert.Student( x , y , a , b , q , r , p );
            }


            for(int i = 0; i<student1.Length;i++)
            {
                Console.WriteLine(student1[i].PrintStu());
            }
            #endregion

            #region Teacher
            inhert.Teacher teacher2 = new inhert.Teacher("12");
            Console.WriteLine(student2.PrintStu());

            inhert.Teacher teacher3 = new inhert.Teacher("12", "nour");
            Console.WriteLine(student3.PrintStu());

            inhert.Teacher teacher4 = new inhert.Teacher("12", "nour", "Ali");
            Console.WriteLine(student4.PrintStu());

            inhert.Teacher teacher5 = new inhert.Teacher("12", "nour", "Ali", "Alex", 25, 25366, "second");
            Console.WriteLine(student5.PrintStu());

            inhert.Teacher teacher = new inhert.Teacher();
            Console.WriteLine(teacher.PrintTea());


            int num2 = 0;
            do
            {
                try
                {
                    Console.WriteLine("\nenter number of Teachers : ");
                    num2 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (num2 < 1);

            inhert.Teacher[] teacher1 = new inhert.Teacher[num2];

            for (int i = 0; i < teacher1.Length; i++)
            {
                //string _id, string _fname, string _lname, string _address, int _age, double _salary, string _subject
                Console.WriteLine($"enter Student {i + 1} id :");
                string x = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} First name :");
                string y = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Last name :");
                string a = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Address :");
                string b = Console.ReadLine();

                Console.WriteLine($"enter Student {i + 1} Age :");
                int q = int.Parse(Console.ReadLine());

                Console.WriteLine($"enter Student {i + 1} Salary :");
                double r = double.Parse(Console.ReadLine());

                Console.WriteLine($"enter Student {i + 1} Subject :");
                string p = Console.ReadLine();

                teacher1[i] = new inhert.Teacher(x, y, a, b, q, r, p);
            }


            for (int i = 0; i < teacher1.Length; i++)
            {
                Console.WriteLine(teacher1[i].PrintTea());
            }
            #endregion

        }
    }
}
