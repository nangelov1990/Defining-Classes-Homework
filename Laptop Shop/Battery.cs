using System.Text;

namespace Laptop_Shop
{
    using System;

    class Battery
    {
        private string batteryType;
        private int? batteryLife ;

        public Battery(string batteryType, int? batteryLife = null)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Cannot be empty", value);
                }

                this.batteryType = value;
            }
        }

        public int? BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (this.BatteryType != null && (value != null && value < 1))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string batteryInfo = string.Format(
                ((this.BatteryType != null) ? string.Format("Battery: {0}\n", this.BatteryType) : null) + 
                ((this.BatteryLife != null) ? string.Format("Battery life: {0} hours\n", this.BatteryLife) : null));

            return batteryInfo;
        }
    }
}
