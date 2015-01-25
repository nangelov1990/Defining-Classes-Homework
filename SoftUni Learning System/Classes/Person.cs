namespace SoftUni_Learning_System
{
    using System;

    class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        protected string printout;
        
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

            printout = string.Format(
                "Name: {0} {1}\nAge: {2}\n",
                this.FirstName,
                this.LastName,
                this.Age);
        }

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty.");
                }

                this._firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty.");
                }

                this._lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this._age = value;
            }
        }

        public override string ToString()
        {
            return printout;
        }
    }

}
