using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    abstract class Question
    {
        public int num;
        public string body;
        public int mark;

        public Question(string body, int mark,int num)
        {
            this.body = body;
            this.mark = mark;
            this.num = num;
        }


    }
}
