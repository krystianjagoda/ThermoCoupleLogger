using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoCoupleLogger
{


    public class Channel_Data
    {
        public uint Number;                     // Position in Array
        public string Name;                     // Channel Name

        public Int32 RawData;                   // Actual Raw Data 
        public uint Fault;                      // Channel Actual Faults
        public uint ViewSetting = 0;            // Display Preview as: 0 = Act, 1 = Max, 2 = Min, 3 = Avg
        public decimal Temperature;             // Actual Temperature
        public decimal JunctionTemp;            // Actual Junction Temperature

        public System.Drawing.Color Color = new System.Drawing.Color();     // Channel Color

    }
}
