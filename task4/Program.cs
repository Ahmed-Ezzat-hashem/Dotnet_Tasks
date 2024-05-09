using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Passing Value By Ref 
            int nu = 0;
            do
            {
                try
                {
                    Console.WriteLine("enter size of array : ");
                    nu = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (nu < 1);

            int[] arr = new int[nu];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter value nu. {i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            print(arr);
            //Console.WriteLine("\nenter first index to Swap whit another ");
            //int Findex = int.Parse(Console.ReadLine());
            int Findex = -1, Lindex = -1;
            do
            {
                try
                {
                    Console.WriteLine("\nenter first index to Swap whit another ");
                    Findex = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (Findex < 0 || Findex >= arr.Length);

            //Console.WriteLine("\nenter first index to Swap whit another ");
            //int Lindex = int.Parse(Console.ReadLine());

            do
            {
                try
                {
                    Console.WriteLine("\nenter second index to Swap ");
                    Lindex = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (Lindex < 0 || Lindex >= arr.Length);


            //Swap(ref arr, ref Findex, ref Lindex);
            //print(arr);

            //static void Swap(ref int[] arr, ref int x, ref int y)
            //{
            //    int temp = arr[x];
            //    arr[x] = arr[y];
            //    arr[y] = temp;
            //}

            //static void print(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"{arr[i]}\t");
            //    }
            //}


            Swap( arr, Findex, Lindex);
            print(arr);

            static void Swap( int[] arr, int x, int y)
            {
                int temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }

            static void print(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}\t");
                }
            }
            #endregion

            #region Clc
            while (true)
            {
                try
                {
                    Console.Write("\nEnter the operation (+, -, *, /, % , e=Exit ): ");
                    char op = char.Parse(Console.ReadLine());
                    if (op == 'e')
                    {
                        break;
                    }
                    Console.Write("Enter the first number: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    int y = int.Parse(Console.ReadLine());    
                    int result;
                    switch (op)
                    {
                        case '+':
                            result = MyMath.Add(x, y);
                            Console.WriteLine("Result= " + result);
                            break;
                        case '-':
                            result = MyMath.Sub(x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '*':
                            result = MyMath.Mul(x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '/':
                            if (y == 0) throw new DivideByZeroException("cant divide by zero");
                            result = MyMath.Div(x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '%':
                            result = MyMath.Mod(x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case 'e':
                            break;
                        default:
                            throw new Exception("must select between ( + , - , * , / , % , e=Exit)");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion

            #region Student
            Student stud = new Student();
            Console.WriteLine($"Enetr data of student :");
            Console.WriteLine($"Enetr ssn :");
            stud.SetSSN(Console.ReadLine());

            Console.WriteLine($"Enetr name :");
            stud.SetName(Console.ReadLine());

            do
            {
                try
                {
                    Console.WriteLine("Enter Student age:");
                    stud.SetAge(int.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (stud.GetAge() < 18 || stud.GetAge() > 45);

            //Console.WriteLine($"Enetr age :");
            //stud.SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Enetr address :");
            stud.SetAddress(Console.ReadLine());

            Console.WriteLine(stud.Print());


            int num1 = 0;
            do
            {
                try
                {
                    Console.WriteLine("\nenter number of Student : ");
                    num1 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (num1 < 1);

            Student[] studarr = new Student[num1];
            for (int i =0; i< num1; i++)
            {
                try
                {
                    studarr[i] = new Student();
                    Console.WriteLine($"Enetr data of student {i + 1} :");
                    Console.WriteLine($"Enetr ssn :");
                    studarr[i].SetSSN(Console.ReadLine());

                    Console.WriteLine($"Enetr name :");
                    studarr[i].SetName(Console.ReadLine());

                    do
                    {
                        try
                        {
                            Console.WriteLine("Enter Student age:");
                            studarr[i].SetAge(int.Parse(Console.ReadLine()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (studarr[i].GetAge() < 18 || studarr[i].GetAge() > 45);

                    //Console.WriteLine($"Enetr age :");
                    //studarr[i].SetAge(int.Parse(Console.ReadLine()));

                    Console.WriteLine($"Enetr address :");
                    studarr[i].SetAddress(Console.ReadLine());
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            for(int i = 0; i <studarr.Length;i++)
            {
                Console.WriteLine(studarr[i].Print());
            }
            #endregion
        }

        #region class MyMath Clc
        class MyMath
        {
            public static int Add(int x , int y)
            {
                return x + y;
            }

            public static int Sub(int x, int y)
            {
                return x - y;
            }

            public static int Mul(int x, int y)
            {
                return x * y;
            }

            public static int Div(int x, int y)
            {
                return x / y;
            }

            public static int Mod(int x, int y)
            {
                return x % y;
            }
        }
        #endregion

        #region Student Class
        class Student
        {
            // size
            private string ssn;
            private string name;
            private int age;
            private string address;

            //setters
            public void SetSSN(string _ssn) { ssn = _ssn; }
            public void SetName(string _name) { name = _name; }
            public void SetAge(int _age) { age = _age; }
            public void SetAddress(string _address) { address = _address; }

            //getters
            public string GetSSN() { return ssn; }
            public string GetName() { return name; }
            public int GetAge() { return age; }
            public string GetAddress() { return address; }


            public string Print()
            {
                return $"\nSSN: {ssn},\nName: {name},\nAge: {age},\nAddress: {address}";
            }


        }
        #endregion
    }
}