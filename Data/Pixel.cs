using System;

namespace MyPhotoshop
{
    public class Pixel
    {
        private double r;

        public double R
        {
            get { return r; }
            set
            {
                r = Check(value);
            }
        }

        private double g;

        public double G
        {
            get => g;
            set => Check(value);
        }

        private double b;

        public double B
        {
            get => b;
            set => Check(value);
        }

        public double Check(double value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException();
            }

            return value;
        }

       public static double Trim(double value)
        {
            if (value<0)
            {
                return 0;
            }

            if (value>1)
            {
                return 1;
            }

            return value;
        }
    }
}
