using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        public Battery battery;
        public Display display;

        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", 1099m, "", new Battery("Z1999", 2, 1.2, BatteryType.NiCd), new Display(4, 1000));

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            if (model == String.Empty)
            {
                throw new ArgumentException("The model of GSM must be defined.");
            }

            if (manufacturer == String.Empty)
            {
                throw new ArgumentException("The manufacturer of GSM must be defined.");
            }

            if (price < 0)
            {
                throw new ArgumentException("The price must be positive number.");
            }

            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null, null, null)
        {
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufactorer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive number.");
                }

                this.price = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public void AddNewCall(string dialedNumber, int duration)
        {
            Call newCall = new Call(dialedNumber, duration);
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
            int minutes = 0;
            int reminder = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                minutes += this.callHistory[i].Duration / 60;
                reminder = this.callHistory[i].Duration % 60;

                if (reminder != 0)
                {
                    minutes++;
                }
            }

            return minutes * pricePerMinute;
        }

        public override string ToString()
        {
            return string.Format("Model: {0}" + Environment.NewLine + "Manufactorer: {1}" + Environment.NewLine + "Price: {2}" + Environment.NewLine + "Owner: {3}"
                + Environment.NewLine + "Display size: {4}" + Environment.NewLine + "Display number of colors: {5}" + Environment.NewLine
                + "Battery model: {6}" + Environment.NewLine + "Battery hours idle: {7}" + Environment.NewLine + "Battery hours talk: {8}"
                + Environment.NewLine + "Battery type: {9}",
                this.model, this.manufacturer, this.price, this.owner, this.display.Size, this.display.NumberOfColors, this.battery.Model, this.battery.HoursIdle,
                this.battery.HoursTalk, this.battery.BatteryType);
        }
    }
}