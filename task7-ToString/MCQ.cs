using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    using System;

    class MCQ : Question
    {
        private string[] answers;

        public MCQ() : this("how are you?",new string[] {"good","bad" },1,1)
        {
        }
        public MCQ(string body, string[] answers, int mark , int num) : base(body, mark,num)
        {
            this.answers = answers;
        }

        public override string ToString()
        {

            Console.WriteLine($"Question {num} : {body} ({mark} marks)\nAnswers :");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}. {answers[i]}");
            }
            return " ";
            
        }

        public override bool Equals(object? obj)
        {
            MCQ quest = (MCQ)obj;
            return this.body == quest.body && this.mark == quest.mark && this.num == quest.num;
        }

    }
}
