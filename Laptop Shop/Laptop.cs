namespace Laptop_Shop
{
    using System;

    class Laptop
    {
        private string _model;
        private string _manufacturer;
        private string _processor;
        private double? _ram;
        private string _graphicsCard;
        private int? _hdd;
        private double? _screen;
        private double _price;

        public Laptop(string model, double price, string manufacturer = null, string processor = null, double? ram = null,
            string graphicsCard = null, int? hdd = null, double? screen = null, Battery battery = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Price = price;
            this.Battery = battery;
        }

        public Laptop(string model, double price)
            : this(model, price, null, null, null, null, null, null, null)
        {
        }

        public string Model
        {
            get { return this._model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value);
                }

                this._model = value;
            }
        }

        public string Manufacturer
        {
            get { return this._manufacturer; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException(value);
                }

                this._manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this._processor; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException(value);
                }

                this._processor = value;
            }
        }

        public double? Ram
        {
            get { return this._ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this._ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this._graphicsCard; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException(paramName: value);
                }

                this._graphicsCard = value;
            }
        }

        public int? Hdd
        {
            get { return this._hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this._hdd = value;
            }
        }

        public double? Screen
        {
            get { return this._screen; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this._screen = value;
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

        public Battery Battery { get; set; }

        public override string ToString()
        {
            string additionalInfo = string.Format(

                ((this.Manufacturer != null) ? string.Format("Manufacturer: {0}\n", this.Manufacturer) : null) +

                ((this.Processor != null) ? string.Format("Processor: {0}\n", this.Processor) : null) +

                (this.Ram != null ? string.Format("RAM: {0} GB\n", this.Ram) : null) +

                ((this.GraphicsCard != null) ? string.Format("Graphics Card: {0}\n", this.GraphicsCard) : null) +

                (this.Hdd != null ? string.Format("HDD: {0} GB\n", this.Hdd) : null) +

                (this.Screen != null ? string.Format("Screen: {0} in\n", this.Screen) : null) +

                (this.Battery ?? null));
            
            string information = string.Format("LAPTOP\n" +
                                "Model: {0}\n" +
                                (additionalInfo ?? null) +
                                "Price: {1} lv\n",
                                this.Model,
                                this.Price);

            return information;
        }
    }
}
