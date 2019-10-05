using System;

namespace UserInformation
{
    public class Person
    {
        private string _fname;
        private string _lname;
        private int _age;
        private string _horoscope;

        public Person(string fname, string lname, int age, string horoscope)
        {
            _fname = fname;
            _lname = lname;
            _age = age;
            _horoscope = horoscope;

        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }

        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }

        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }

        }

        public string Horoscope
        {
            get { return _horoscope; }
            set { _horoscope = value; }

        }

    }
}
