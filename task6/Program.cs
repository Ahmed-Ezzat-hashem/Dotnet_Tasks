using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char x='1';
            int y = -1;
            //Question q6 = new MCQ();
            //q6.Show();
            while (true)
            {
                if (y == 0) break;
                Console.WriteLine("Hello! \nplz enter number  : 1 .if you want MCQ Questions.\n\t\t    2 .if you want T/F Question.\n\t\t    3 .if you want to Exit.");
                try
                {
                    do
                    {
                        x = char.Parse(Console.ReadLine());
                        if (x != '1' && x != '2' && x != '3') throw new Exception("Please Enter between : 1 , 2 , 3\t");
                    } while (x != '1' && x != '2' && x != '3');
                }catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }

                switch (x)
                {
                    case '1':

                        TestShape test = new TestShape();
                        test.Answers = new string[] { "London", "Paris", "Berlin", "Madrid" };
                        MCQ q1 = new MCQ("What is the capital of France?", test.Answers, 1);
                        q1.Show();

                        test.Answers = new string[] { "London", "Cairo", "Berlin", "Madrid" };
                        MCQ q3 = new MCQ("What is the capital of Egypt?", test.Answers, 1);
                        q3.Show();

                        break;
                    case '2':

                        TrueOrFalse q2 = new TrueOrFalse("Paris is the capital of France.", true , 1);
                        q2.Show();

                        TrueOrFalse q4 = new TrueOrFalse("Cairo is the capital of Taxas.", false , 1);
                        q2.Show();
                        break;

                    case '3':
                        y = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
