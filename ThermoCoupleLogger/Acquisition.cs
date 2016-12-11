using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoCoupleLogger
{
    public class Acquisition
    {
        public bool Logging = false;
        public bool LimitSet = false;

        public decimal mSec;
        public decimal Sec;
        public decimal Min;

        public Int32 Period;   // Period in ms
        public UInt32 SampleLimit = 50;
         
        public Int32 Countdown;


        public void CalculatePeriod()
        {
            Period = (Int32)mSec + (Int32)Sec * 1000 + (Int32)Min * 60000;
            Countdown = Period;
        }
        
    }
}
