using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoCoupleLogger
{

    public class TotalAcquisitionTime{

        public UInt32 TotalTime;
        public UInt32 TotalDays;
        public UInt32 TotalHours;
        public UInt32 TotalMinutes;
        public UInt32 TotalSeconds;

        public decimal mSec;
        public decimal Sec;
        public decimal Min;

        public UInt32 Period;   // Period in ms
        public UInt32 SampleLimit = 50;

        public UInt32 Countdown;

        public void CalculatePeriod()
        {
            Period = (UInt32)mSec + (UInt32)Sec * 1000 + (UInt32)Min * 60000;
            Countdown = Period;
        }

        public void CalculateTotalTime(UInt32 Sample)
        {
            TotalTime = (UInt32)(Period * Sample) / 1000;
            TotalDays = TotalTime / 86400;
            TotalHours = (TotalTime - (86400 * TotalDays)) / 3600;
            TotalMinutes = (TotalTime - (86400 * TotalDays) - (3600 * TotalHours)) / 60;
            TotalSeconds = (TotalTime - (86400 * TotalDays) - (3600 * TotalHours) - (60 * TotalMinutes));
        }
    }




    public class Acquisition
    {
        public TotalAcquisitionTime CalculatedTime = new TotalAcquisitionTime();    // Calculated Value for Labels etc.
        public TotalAcquisitionTime TimeLeft = new TotalAcquisitionTime();          // Actual Value for Timers etc.

        public DateTime startTime = DateTime.Now;
        public DateTime countTime;

        public bool Logging = false;
        public bool LimitSet = false;

        public string TimeToNextSample()
        {
            string Time;

            UInt32 CountDownTime = 0;
            UInt32 Minutes = 0;
            UInt32 Seconds = 0;

            if (Logging)
            {
                DateTime countTime = DateTime.Now;
                long differenceTime = startTime.Ticks - countTime.Ticks;
                CountDownTime = (UInt32)((CalculatedTime.Period / 100) + ((differenceTime) / 1000000));
            }
            else
            {
                CountDownTime = (UInt32)(CalculatedTime.Period / 100);
            }

            Minutes = (UInt32)(CountDownTime / 600);
            Seconds = (UInt32)(CountDownTime - (600 * Minutes));

            Time = Minutes.ToString() + ":" + (Seconds / 10).ToString() + "." + (Seconds % 10).ToString();
            return Time;
        }

        
    }
}
