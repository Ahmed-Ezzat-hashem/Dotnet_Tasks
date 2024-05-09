using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.inhert
{
    public class Student : Person
    {
        private string schoolyear;
        private string _class;


        public Student()
        {
            Id = "253";
            Fname = "Ali";
            Lname = "Mohamed";
            Address = "Alex";
            Age = 33;
            Schoolyear = "second";
            _Class = "third";
        }

        public Student(string _id)
        {
            Id = _id;
        }
        public Student(string _id, string _fname)
        {
            Id = _id;
            Fname = _fname;
        }
        public Student(string _id, string _fname, string _lname)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
        }
        public Student(string _id, string _fname, string _lname, string _address)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
        }

        public Student(string _id, string _fname, string _lname, string _address, int _age)
        {

            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
        }

        public Student(string _id, string _fname, string _lname, string _address, int _age, string _schoolyear)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
            Schoolyear = _schoolyear;
        }

        public Student(string _id, string _fname, string _lname, string _address, int _age, string _schoolyear, string _class)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
            Schoolyear = _schoolyear;
            _Class = _class;
        }

        public string Schoolyear
        {
            get { return schoolyear; }
            set { schoolyear = value; }
        }

        public string _Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public string PrintStu()
        {
            return $"\nStudents : {this.Print()}, Schoolyear: {schoolyear}, Class: {_class}";
        }
    }
}
