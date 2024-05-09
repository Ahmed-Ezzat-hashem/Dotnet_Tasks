using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class TrueOrFalse : Question
    {
        private bool answer;

        public TrueOrFalse(string body, bool answer,int mark) : base(body, mark)
        {
            this.answer = answer;
        }

        public override void Show()
        {
            Console.WriteLine($"\nQuestion {Question.num++} : {body}  'True or Flase' ");
            Console.WriteLine($"The Answer: {answer} \t({mark} mark)");
        }
    }
}