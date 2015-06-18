namespace GSMClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum BatteryTypes
    {
        LiIon, NiMH, NiCd
    }

    class Battery
    {
        //filds
        private string model;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryTypes batteryType;

        //constructors
        public Battery(string model, BatteryTypes batteryType)
            : this(model, batteryType,  null, null)
        { 
        }

        public Battery(string model, BatteryTypes batteryType, float? hoursIdle, float? hoursTalk)
        {
            this.Model = model;
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public float? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public float? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public BatteryTypes BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("------------Battery------------");
            result.AppendLine("Batery model: " + this.Model.ToString());
            result.AppendLine("Batery Hours Idle: " + this.HoursIdle.ToString() + " h");
            result.AppendLine("Batery Hours Talk: " + this.HoursTalk.ToString() + " h");
            result.AppendLine("Batery Type: " + this.BatteryType.ToString());
            return result.ToString().TrimEnd();

        }
    }
}
