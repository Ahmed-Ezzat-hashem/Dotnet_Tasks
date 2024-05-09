using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Studentl
    {
        // size
        private string ssn;
        private string name;
        private int age;
        private string address;


        public Studentl()
        {
            ssn = "253";
            name = "Ali";
            Age = 33;
            Address = "Alex";
        }

        public Studentl(string _ssn)
        {
            Ssn = _ssn;
        }
        public Studentl(string _ssn, string _name)
        {
            Ssn = _ssn;
            name = _name;
        }
        public Studentl(string _ssn, string _name, int _age)
        {
            Ssn = _ssn;
            name = _name;
            Age = _age;
        }


        //setters
        public void SetSSN(string _ssn) { ssn = _ssn; }
        public void SetName(string _name) { name = _name; }
        public void SetAge(int _age) { age = _age; }
        public void SetAddress(string _address) { address = _address; }

        //getters
        public string GetSSN() { return ssn; }
        public string GetName() { return name; }
        public int GetAge() { return age; }
        public string GetAddress() { return address; }

        //prop
        public String Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
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

        public String Address
        {
            get { return address; }
            set { address = value; }
        }


        public string PrintS()
        {
            return $"\nSSN: {ssn},\nName: {name},\nAge: {age},\nAddress: {address}";
        }
    }
}
