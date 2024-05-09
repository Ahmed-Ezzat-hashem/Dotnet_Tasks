using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            TestShape test = new TestShape();
            test.Answers = new string[] { "London", "Paris", "Berlin", "Madrid" };
            MCQ q1 = new MCQ("What is the capital of France?", test.Answers, 1,1);
            q1.ToString();

            test.Answers = new string[] { "London", "Paris", "Berlin", "Madrid" };
            MCQ q5 = new MCQ("What is the capital of France?", test.Answers, 1, 1);

            if (q1.Equals(q5)) Console.WriteLine("\nthey are Equal");
            else Console.WriteLine("\nthey are not Equal");

            test.Answers = new string[] { "London", "Cairo", "Berlin", "Madrid" };
            MCQ q3 = new MCQ("What is the capital of Egypt?", test.Answers, 2,2);
            q3.ToString();

            if (q3.Equals(q5)) Console.WriteLine("\nthey are Equal");
            else Console.WriteLine("\nthey are not Equal");

            TrueOrFalse q2 = new TrueOrFalse("Paris is the capital of France.", true , 2 ,3);
            q2.ToString();

            TrueOrFalse q4 = new TrueOrFalse("Cairo is the capital of Taxas.", false , 1 , 4);
            q2.ToString();
        
        }
    }
}
