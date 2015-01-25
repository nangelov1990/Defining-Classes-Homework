namespace PC_Catalog.Classes
{
    using System;

    class Component
    {
        private string _name;
        private string _details;
        private double _price;

        public Component(string name, double price) : this(name, null, price)
        {
        }

        public Component(string name, string details, double price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }



        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }

                this._name = value;
            }
        }

        public string Details
        {
            get { return this._details; }
            set
            {
                //if (value != null && value.Length < 1)
                //{
                //    throw new ArgumentException("Details cannot be empty!");
                //}

                this._details = value;
            }
        }

        public double Price
        {
            get { return this._price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this._price = value;
            }
        }

        public override string ToString()
        {
            string additionalInfo = null;

            if (this.Details != null)
            {
                additionalInfo = string.Format("|| Details: {0} ", this.Details);
            }

            string information = string.Format(
                "Component: {0} {1}|| Price: ${2}",
                this.Name,
                additionalInfo,
                this.Price);

            return information;
        }
    }
}
