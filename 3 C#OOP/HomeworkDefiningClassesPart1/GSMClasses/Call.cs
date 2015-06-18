namespace GSMClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Call
    {
        //fields
        private DateTime callDateTime;
        private string dialledPhoneNumber;
        private int duration;

        //constructor
        public Call(DateTime callDateTime, string dialledPhoneNumber, int duration)
        {
            this.CallDateTime = callDateTime;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        //properties
        public DateTime CallDateTime
        {
            get { return this.callDateTime; }
            set { this.callDateTime = value; }
        }

        public string DialledPhoneNumber
        {
            get { return this.dialledPhoneNumber; }
            set { this.dialledPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
