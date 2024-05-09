using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class TrueOrFalse : Question
    {
        private bool answer;

        public TrueOrFalse(string body, bool answer,int mark , int num) : base(body, mark,num)
        {
            this.answer = answer;
        }

        public override string ToString()
        {
            Console.WriteLine($"\nQuestion {num} : {body}  'True or Flase' \nThe Answer: {answer} \t({mark} mark)");
            return "";
        }

        public override bool Equals(object? obj)
        {
            TrueOrFalse quest = (TrueOrFalse)obj;
            return this.body == quest.body && this.answer == quest.answer && this.mark == quest.mark && this.num == quest.num;
        }

    }
}