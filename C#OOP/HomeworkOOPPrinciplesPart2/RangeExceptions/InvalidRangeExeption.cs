namespace RangeExceptions
{
    using System;

    public class InvalidRangeExeption<T> : ApplicationException
    {
        private T min;
        private T max;

        public T Min
        {
            get { return this.min; }
            set { this.min = value; }
        }
        public T Max
        {
            get { return this.max; }
            set { this.max = value; }
        }

        public InvalidRangeExeption(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public override string Message
        {
            get
            {
                string result = string.Format("The value is out of the range {0} - {1}", this.Min, this.Max);
                return result;
            }
        }
    }
}
