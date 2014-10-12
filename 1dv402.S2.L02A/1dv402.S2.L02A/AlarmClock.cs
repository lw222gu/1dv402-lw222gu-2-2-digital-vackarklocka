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

        //Properties

        public int AlarmHour
        {
            get { return _alarmHour;  }
            set {
                    if (_alarmHour < 0 || _alarmHour > 23)
                    {
                        throw new ArgumentException();
                    } 
                    _alarmHour = value; 
                }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set {
                    if (_alarmMinute < 0 || _alarmMinute > 59)
                    {
                        throw new ArgumentException();
                    }
                    _alarmMinute = value; 
                }
        }

        public int Hour
        {
            get { return _hour; }
            set {
                    if (_hour < 0 || _hour > 23)
                    {
                        throw new ArgumentException();
                    }
                    _hour = value; 
                }
        }

        public int Minute
        {
            get { return _minute; }
            set {
                    if (_minute < 0 || _minute > 59)
                    {
                        throw new ArgumentException();
                    }
                    _minute = value; 
                }
        }

        //Constructors

        public AlarmClock()
        { 
        }

        public AlarmClock(int hour, int minute)
        { 
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        { 
        }

        //Methods

        public bool TickTock()
        { 
        }

        public string ToString()
        { 
        }
    }
}
