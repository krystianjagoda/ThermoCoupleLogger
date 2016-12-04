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

        public decimal mSec;
        public decimal Sec;
        public decimal Min;

        public int Period;   // Period in ms
        public UInt32 SampleLimit;


        public void CalculatePeriod()
        {
            Period = (int)mSec + (int)Sec * 1000 + (int)Min * 60000;
        }
    }
}
