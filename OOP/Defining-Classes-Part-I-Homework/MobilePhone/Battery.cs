using System;

namespace MobilePhone
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public Battery(string model)
            : this(model, 0.0, 0.0, 0)
        {
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Hours Idle cannot be a negative number");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Hours Talk cannot be a negative number");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType 
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }
}
