using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    using System;

    class MCQ : Question
    {
        private string[] answers;

        public MCQ() : this("how are you?",new string[] {"good","bad" },1)
        {
        }
        public MCQ(string body, string[] answers, int mark) : base(body, mark)
        {
            this.answers = answers;
        }

        public override void Show()
        {

            Console.WriteLine($"Question {Question.num++} : {body} ({mark} marks)");
            Console.WriteLine("Answers:");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}. {answers[i]}");
            }
        }
    }
}
