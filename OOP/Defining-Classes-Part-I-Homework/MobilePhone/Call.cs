using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class Call
    {
        private DateTime date;
        private string time;
        private string dialedNumber;
        private int duration;

        public Call(string dialedNumber, int duration)
        {
            DateTime date = DateTime.Now;

            string hour = "";
            string minutes = "";
            string seconds = "";

            if (date.Hour >= 0 && date.Hour <= 9)
            {
                hour = "0" + date.Hour;
            }
            else if (date.Minute >= 0 && date.Minute <= 9)
            {
                minutes = "0" + date.Minute;
            }
            else if (date.Second >= 0 && date.Second <= 9)
	        {
                seconds = "0" + date.Second;
	        }
            else
            {
                hour += date.Hour;
                minutes += date.Minute;
                seconds += date.Second;
            }

            string time = hour + ":" + minutes + ":" + seconds;

            this.date = date;
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
        }

        public string Time
        {
            get { return this.time; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
        }

        public int Duration
        {
            get { return this.duration; }
        }

        public override string ToString()
        {
            return string.Format("Date: {0:dd.MM.yyyy}" + Environment.NewLine + "Time: {1}"
                + Environment.NewLine + "Dialed number: {2}" + Environment.NewLine + "Duration: {3}", this.date, this.time, this.dialedNumber, this.duration);
        }
    }
}