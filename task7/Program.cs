using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Clculator
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
                            result = CLC("add",x, y);
                            Console.WriteLine("Result= " + result);
                            break;
                        case '-':
                            result = CLC("sub", x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '*':
                            result = CLC("mul", x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '/':
                            if (y == 0) throw new DivideByZeroException("cant divide by zero");
                            result = CLC("div", x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case '%':
                            result = CLC("mod", x, y);
                            Console.WriteLine("Result = " + result);
                            break;
                        case 'e':
                            break;
                        default:
                            Console.WriteLine("invalied operator input");
                            break;
                    }
                }catch(Exception)
                {
                    Console.WriteLine("must select between ( + , - , * , / , % , e=Exit)");
                }
            }
            #endregion

            #region using enum
            Console.Write("Enter a number between 1 and 7: ");
            int dayNum = int.Parse(Console.ReadLine());

            days dayOfWeek = new days();
            if (dayNum>0 && dayNum <8)
            {
                dayOfWeek = (days)dayNum;
            }
            else
            {
                Console.WriteLine("Invalid number Please enter a number between 1 and 7.");
            }

            Console.WriteLine($"The day name is {dayOfWeek}.");
            #endregion
        }
        #region clc method
        public static int CLC(string op, int x, int y)
        {
            switch (op)
            {
                case "add":
                    return MyMath.Add(x, y);
                case "sub":
                    return MyMath.Sub(x, y);
                case "mul":
                    return MyMath.Mul(x, y);
                case "div":
                    return MyMath.Div(x, y);
                case "rem":
                    return MyMath.Mod(x, y);
                default:
                    throw new Exception("Invalid Operator");
            }
        }
        #endregion
    }
}
