namespace Persons
{
    using System;

    class Person
    {
        private string _name;
        private int _age;
        private string _email;
        
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty.");
                }

                this._name = value;
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

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must contain '@' sign.");
                }

                this._email = value;
            }
        }

        public override string ToString()
        {
            string mainMessage = string.Format("PERSON\nName: {0}\nAge: {1}", this.Name, this.Age);
            string additionalsMessage = string.Format("\nEmail: {0}", this.Email);

            return mainMessage
                + (string.IsNullOrEmpty(this.Email) ? null : additionalsMessage)
                + "\n";
        }
    }
}
