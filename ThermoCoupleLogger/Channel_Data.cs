using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoCoupleLogger
{


    public class Channel_Data
    {
        public Int32 RawData;           // Actual Raw Data 
        public string Name;             // Channel Name
        public uint Fault;              // Channel Actual Faults
        public uint ViewSetting;        // Display Preview as: Act, Max, Min, Avg
        public decimal Temperature;     // Actual Temperature
        public decimal JunctionTemp;    // Actual Junction Temperature

        public System.Drawing.Color Color = new System.Drawing.Color();

    }
}
