using System.Linq;
using System.Text;

namespace PC_Catalog.Classes
{
    using System;
    using PC_Catalog.Classes.Components;

    class Computer
    {
        private string _name;
        private Component[] _components;
        private Component[] component;


        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, Component[] components) : this(name)
        {
            this.Components = components;
        }
        
        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this._name = value;
            }
        }

        public Component[] Components
        {
            get { return this._components; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this._components = value;
            }
        }

        public double Price
        {
            get
            {
                double price = 0;

                if (this.Components != null)
                {
                    price = this.Components.Sum(a => a.Price);
                }

                return price;
            }
        }

        public override string ToString()
        {
            StringBuilder additionalInfo = new StringBuilder();

            if (this.Components != null)
            {
                foreach (var component in this.Components)
                {
                    additionalInfo.AppendLine(component.ToString());
                }
            }
            
            string information = string.Format(
                "COMPUTER\nName: {0}\n{1}{2}",
                this.Name,
                additionalInfo,
                ((this.Price > 0) ? string.Format("Price: ${0}\n", this.Price) : null));

            return information;
        }
    }
}
