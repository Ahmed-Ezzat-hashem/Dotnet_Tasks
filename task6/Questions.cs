using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    abstract class Question
    {
        public static int num=1;
        public string body;
        public int mark;

        public Question(string body, int mark)
        {
            this.body = body;
            this.mark = mark;
        }

        public abstract void Show();
    }
}
