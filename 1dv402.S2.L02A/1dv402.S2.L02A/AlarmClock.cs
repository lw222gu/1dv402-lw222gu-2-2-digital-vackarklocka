using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L02A
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //Egenskaper

        public int AlarmHour
        {
            get { return _alarmHour;  }
            set {
                    if (value < 0 || value > 23)
                    {
                        throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                    } 
                    _alarmHour = value; 
                }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set {
                    if (value < 0 || value > 59)
                    {
                        throw new ArgumentException("Minuterna är inte i intervallet 00-59."); 
                    }
                    _alarmMinute = value;
                }
        }

        public int Hour
        {
            get { return _hour; }
            set {
                    if (0 > value || value > 23)
                    {
                        throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                    }
                    _hour = value; 
                }
        }

        public int Minute
        {
            get { return _minute; }
            set {
                    if (value < 0 || value > 59)
                    {
                        throw new ArgumentException("Minuterna är inte i intervallet 00-59.");
                    }
                    _minute = value; 
                }
        }

        //Konstruktorer

        public AlarmClock()
            :this(0,0)
        { 
        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        { 
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //Metoder

        public bool TickTock()
        {
            
            //Öka med en minut

            if (Minute < 59)
            {
                Minute++;
            }

            else
            {
                Minute = 0;

                if (Hour < 23)
                {
                    Hour++;
                }

                else
                {
                    Hour = 0;
                }
                
            }

            
            //Kontrollera om alarmtiden är densamma som tiden

            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}:{1:D2} ({2}:{3:D2})", Hour, Minute, AlarmHour, AlarmMinute);
        }
    }
}
