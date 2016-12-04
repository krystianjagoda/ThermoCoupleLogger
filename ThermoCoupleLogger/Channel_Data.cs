using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoCoupleLogger
{


    public class Channel_Data
    {


        public string Name;                     // Channel Name

        public Int32 RawData;                   // Actual Raw Data 
        public uint Fault;                      // Channel Actual Faults
        public uint ViewSetting = 0;            // Display Preview as: 0 = Act, 1 = Max, 2 = Min, 3 = Avg

        public System.Drawing.Color Color = new System.Drawing.Color();     // Channel Color

        public decimal MaxTemperature = 0;          // Maximum Temperature
        public decimal MinTemperature = 0;          // Minimum Temperature
        public decimal AvgTemperature = 0;          // Avarage Temperature
        public decimal Temperature = 0;             // Actual Temperature
        public decimal JunctionTemp = 0;            // Actual Junction Temperature




        
        // Dodac dynamiczna macierz z danymi



    }

    public class Sample : IEquatable<Sample>
    {

        

        public UInt32 SampleNumber { get; set; }
        public Decimal Channel1Values { get; set; }
        public Decimal Channel2Values { get; set; }
        public Decimal Channel3Values { get; set; }
        public Decimal Channel4Values { get; set; }
        public Decimal Channel5Values { get; set; }
        public Decimal Channel6Values { get; set; }
        public Decimal Channel7Values { get; set; }
        public Decimal Channel8Values { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Sample objAsPart = obj as Sample;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override string ToString()
        {
            return "Sample" + SampleNumber + " = " + Channel1Values;
        }

        public override int GetHashCode()
        {
            return (int)SampleNumber;
        }


        public bool Equals(Sample other)
        {
            if (other == null) return false;
            return (this.SampleNumber.Equals(other.SampleNumber));
        }
        // Should also override == and != operators.

    }

}
