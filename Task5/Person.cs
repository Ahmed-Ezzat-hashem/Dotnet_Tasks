using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Person
    {
        //size
        private string id;
        private string fname;
        private string lname;
        private string address;
        private int age;

        //prop
        public string  Id
        { 
            get { return id; }
            set { id = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 20 || value > 40) throw new Exception("Age must be between 20 and 40");
                else
                    age = value;
            }
        }
        //operation
        public string Print()
        {
            return $"id: {id}, Name: {fname}, Name: {lname}, Address: {address}, Age: {age}";
        }

    }
}
