using System;

namespace MobilePhone
{
    public class Display
    {
        private double size;
        private ulong numberOfColors;

        public Display(double size, ulong numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public Display(double size)
            : this(size, 0L)
        {
        }

        public Display(ulong numberOfColors)
            : this(0, numberOfColors)
        {
        }

        public Display()
        {
        }

        public double Size
        {
            get { return this.size; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The size cannot be a negavtive number");
                }

                this.size = value;
            }
        }

        public ulong NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Number of colors cannot be a negavtive number");
                }

                this.numberOfColors = value;
            }
        }
        
    }
}
