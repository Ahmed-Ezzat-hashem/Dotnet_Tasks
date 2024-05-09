using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.inhert
{
    public class Teacher : Person
    {
        private double salary;
        private string subject;

        public Teacher ()
        {
            Id = "100";
            Fname = "Ahmed";
            Lname = "Ezzat";
            Address = "Cairo";
            Age = 25;
            Salary = 25000;
            Subject = "English";
        }

        public Teacher(string _id)
        {
            Id = _id;
        }

        public Teacher(string _id ,string _fname)
        {
            Id = _id;
            Fname = _fname;
        }
        public Teacher(string _id, string _fname, string _lname)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
        }
        public Teacher(string _id, string _fname, string _lname, string _address)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
        }

        public Teacher(string _id, string _fname, string _lname, string _address, int _age)
        {

            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
        }

        public Teacher(string _id, string _fname, string _lname, string _address, int _age, double _salary)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
            Salary = _salary;
        }

        public Teacher(string _id, string _fname, string _lname, string _address, int _age, double _salary, string _subject)
        {
            Id = _id;
            Fname = _fname;
            Lname = _lname;
            Address = _address;
            Age = _age;
            Salary = _salary;
            Subject = _subject;
        }



        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0 || value > 99999) throw new Exception("Age must be between 0 and 99999");
                else
                    salary = value;
            }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string PrintTea()
        {
            return $"Teachers: {this.Print()}, Subject: {subject}, Salary: {salary}";
        }
    }
}
