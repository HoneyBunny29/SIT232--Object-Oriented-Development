﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyTime
{
    internal class MyTime
    {
        private int second;
        private int minute;
        private int hour;

        public MyTime()
        {
            second = 0;
            minute = 0;
            hour = 0;
        }

        public MyTime(int hour, int minute, int second)
        {
            SetTime(hour, minute, second);
        }

        public void SetTime(int hour, int minute, int second)
        {
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);
        }

        public void SetHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                this.hour = hour;
            }

            else
            {
                Console.WriteLine("Please enter Hour between 0 and 23");
            }
        }
        public void SetMinute(int minute)
        {
            if (minute >= 0 && minute <= 59)
            {
                this.minute = minute;
            }

            else
            {
                Console.WriteLine("Please enter Minute between 0 and 59");
            }
        }

        public void SetSecond(int second)
        {
            if (second >= 0 && second <= 59)
            {
                this.second = second;
            }

            else
            {
                Console.WriteLine("Please enter Second between 0 and 59");
            }
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return minute;
        }

        public int GetSecond()
        {
            return second;
        }

        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public MyTime NextSecond()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                NextMinute();
            }
            return this;
            // The current instance of the MyTime object is returned by this line.
            // This makes it possible to do several operations on a single MyTime object in a single line thanks to method chaining.
        }

        public MyTime NextMinute()
        {
            minute++;
            if (minute == 60)
            {
                minute = 0;
                NextHour();
            }
            return this;
        }

        public MyTime NextHour()
        {
            hour++;
            if (hour == 24)
            {
                hour = 0;
            }
            return this;
        }

        public MyTime PreviousSecond()
        {
            second--;
            if (second < 0)
            {
                second = 59;
                PreviousMinute();
            }
            return this;
            // Method chaining is enabled by this line,
            // which returns the MyTime object instance that is now in use.
        }

        public MyTime PreviousMinute()
        {
            minute--;
            if (minute < 0)
            {
                minute = 59;
                PreviousHour();
            }
            return this;
        }

        public MyTime PreviousHour()
        {
            hour--;
            if (hour < 0)
            {
                hour = 23;
            }
            return this;
        }
    }
}
