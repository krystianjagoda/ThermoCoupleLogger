using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
//using ExcelLibrary.CompoundDocumentFormat;
//using ExcelLibrary.SpreadSheet;
using System.Collections;

namespace ThermoCoupleLogger
{
    public partial class Form1 : Form
    {

        
        public bool DebugMode = false;
        public uint ErrorFrames = 0;

        public UInt32 ActualSampleNumber = 0;       // Actual Sample Number
        public List<Sample> Samples = new List<Sample>();


        Acquisition Acquisition = new Acquisition();
        Channel_Data Channel1 = new Channel_Data();
        Channel_Data Channel2 = new Channel_Data();
        Channel_Data Channel3 = new Channel_Data();
        Channel_Data Channel4 = new Channel_Data();
        Channel_Data Channel5 = new Channel_Data();
        Channel_Data Channel6 = new Channel_Data();
        Channel_Data Channel7 = new Channel_Data();
        Channel_Data Channel8 = new Channel_Data();
        Channel_Data ChannelA = new Channel_Data();



        public Form1()
        {
            InitializeComponent();
            serialPort1.ReadTimeout = 2000; // Read Timeout = 2s

            timerRefresh.Interval = 10;     // GUI Refresh period in ms
            timerRefresh.Enabled = true;


            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
                {
                    if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBoxColorCH1.Items.Add(prop.Name);
                    comboBoxColorCH2.Items.Add(prop.Name);
                    comboBoxColorCH3.Items.Add(prop.Name);
                    comboBoxColorCH4.Items.Add(prop.Name);
                    comboBoxColorCH5.Items.Add(prop.Name);
                    comboBoxColorCH6.Items.Add(prop.Name);
                    comboBoxColorCH7.Items.Add(prop.Name);
                    comboBoxColorCH8.Items.Add(prop.Name);
                }

            // Init Stuff
            DefaultColors();


            Acquisition.mSec = periodmSec.Value;
            Acquisition.Sec = periodSec.Value;
            Acquisition.Min = periodMin.Value;
            Acquisition.CalculatePeriod();

            getAvailablePorts();
            tryToConnect();

            InitialThings();

        }


        public void RefreshGrid(object dataSource)
        {
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataSource];
            myCurrencyManager.Refresh();
        }

        public void NewSample(Decimal CH1_Value, Decimal CH2_Value, Decimal CH3_Value, Decimal CH4_Value,
                              Decimal CH5_Value, Decimal CH6_Value, Decimal CH7_Value, Decimal CH8_Value)
        {
            Samples.Add(new Sample()
            { SampleNumber = ActualSampleNumber,
                SampleTime = DateTime.Now.ToString("h:mm:ss tt"),
                Channel1Values = CH1_Value,
                Channel2Values = CH2_Value,
                Channel3Values = CH3_Value,
                Channel4Values = CH4_Value,
                Channel5Values = CH5_Value,
                Channel6Values = CH6_Value,
                Channel7Values = CH7_Value,
                Channel8Values = CH8_Value,
            });


       //     RefreshGrid(sampleBindingSource1);

    }


        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxCOMs.Items.AddRange(ports);
        }

        void tryToConnect()
        {
            try
            {
                serialPort1.PortName = "COM26";
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                labelConnectionStatus.Text = "Connected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Green;
                buttonStart.Enabled = true;
                timerRead.Enabled = true;
            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Unauthorized Acess";
                labelConnectionStatus.Text = "Disconnected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Maroon;
                timerRead.Enabled = false;
            }
        }

        void registerData()
        {
            NewSample(Channel1.Temperature, Channel2.Temperature, Channel3.Temperature, Channel4.Temperature,
            Channel5.Temperature, Channel6.Temperature, Channel7.Temperature, Channel8.Temperature);

            ActualSampleNumber++;

        }


        void InitialThings()
        {
            //  Make an initial measurement to get Max and Min
            getData();
            Channel1.setMaxMin();
            Channel2.setMaxMin();
            Channel3.setMaxMin();
            Channel4.setMaxMin();
            Channel5.setMaxMin();
            Channel6.setMaxMin();
            Channel7.setMaxMin();
            Channel8.setMaxMin();
            ChannelA.setMaxMin();

        }


        void getData()
        {
            int[] ReceivedFrame = new int[36];
            Int32 Sum = 0; //Frame Sum for Checksum
            Int32 CalculatedCheckSum = 0;

            serialPort1.Write("#get_data\n");

            try
            {
                for(Int16 i = 0; i<36; i++)
                {
                    ReceivedFrame[i] = (int)serialPort1.ReadByte();
                    if(i < 33) Sum = Sum + (Int32)ReceivedFrame[i];  
                }                
            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }

            CalculatedCheckSum = Sum % 255;

            if (CalculatedCheckSum == ReceivedFrame[33])
            {
                Channel1.RawData = ((Int32)ReceivedFrame[1] << 24) + ((Int32)ReceivedFrame[2] << 16) + ((Int32)ReceivedFrame[3] << 8) + ReceivedFrame[4];
                Channel2.RawData = ((Int32)ReceivedFrame[5] << 24) + ((Int32)ReceivedFrame[6] << 16) + ((Int32)ReceivedFrame[7] << 8) + ReceivedFrame[8];
                Channel3.RawData = ((Int32)ReceivedFrame[9] << 24) + ((Int32)ReceivedFrame[10] << 16) + ((Int32)ReceivedFrame[11] << 8) + ReceivedFrame[12];
                Channel4.RawData = ((Int32)ReceivedFrame[13] << 24) + ((Int32)ReceivedFrame[14] << 16) + ((Int32)ReceivedFrame[15] << 8) + ReceivedFrame[16];
                Channel5.RawData = ((Int32)ReceivedFrame[17] << 24) + ((Int32)ReceivedFrame[18] << 16) + ((Int32)ReceivedFrame[19] << 8) + ReceivedFrame[20];
                Channel6.RawData = ((Int32)ReceivedFrame[21] << 24) + ((Int32)ReceivedFrame[22] << 16) + ((Int32)ReceivedFrame[23] << 8) + ReceivedFrame[24];
                Channel7.RawData = ((Int32)ReceivedFrame[25] << 24) + ((Int32)ReceivedFrame[26] << 16) + ((Int32)ReceivedFrame[27] << 8) + ReceivedFrame[28];
                Channel8.RawData = ((Int32)ReceivedFrame[29] << 24) + ((Int32)ReceivedFrame[30] << 16) + ((Int32)ReceivedFrame[31] << 8) + ReceivedFrame[32];

                

                Channel1.Temperature = GetThermocoupleTemp(Channel1.RawData);               
                Channel2.Temperature = GetThermocoupleTemp(Channel2.RawData);
                Channel3.Temperature = GetThermocoupleTemp(Channel3.RawData);
                Channel4.Temperature = GetThermocoupleTemp(Channel4.RawData);
                Channel5.Temperature = GetThermocoupleTemp(Channel5.RawData);
                Channel6.Temperature = GetThermocoupleTemp(Channel6.RawData);
                Channel7.Temperature = GetThermocoupleTemp(Channel7.RawData);
                Channel8.Temperature = GetThermocoupleTemp(Channel8.RawData);

                ChannelA.Temperature = Channel1.JunctionTemp;


                if (Channel1.Temperature > Channel1.MaxTemperature) Channel1.MaxTemperature = Channel1.Temperature;
                if (Channel1.Temperature < Channel1.MinTemperature) Channel1.MinTemperature = Channel1.Temperature;

                if (Channel2.Temperature > Channel2.MaxTemperature) Channel2.MaxTemperature = Channel2.Temperature;
                if (Channel2.Temperature < Channel2.MinTemperature) Channel2.MinTemperature = Channel2.Temperature;

                if (Channel3.Temperature > Channel3.MaxTemperature) Channel3.MaxTemperature = Channel3.Temperature;
                if (Channel3.Temperature < Channel3.MinTemperature) Channel3.MinTemperature = Channel3.Temperature;

                if (Channel4.Temperature > Channel4.MaxTemperature) Channel4.MaxTemperature = Channel4.Temperature;
                if (Channel4.Temperature < Channel4.MinTemperature) Channel4.MinTemperature = Channel4.Temperature;

                if (Channel5.Temperature > Channel5.MaxTemperature) Channel5.MaxTemperature = Channel5.Temperature;
                if (Channel5.Temperature < Channel5.MinTemperature) Channel5.MinTemperature = Channel5.Temperature;

                if (Channel6.Temperature > Channel6.MaxTemperature) Channel6.MaxTemperature = Channel6.Temperature;
                if (Channel6.Temperature < Channel6.MinTemperature) Channel6.MinTemperature = Channel6.Temperature;

                if (Channel7.Temperature > Channel7.MaxTemperature) Channel7.MaxTemperature = Channel7.Temperature;
                if (Channel7.Temperature < Channel7.MinTemperature) Channel7.MinTemperature = Channel7.Temperature;

                if (Channel8.Temperature > Channel8.MaxTemperature) Channel8.MaxTemperature = Channel8.Temperature;
                if (Channel8.Temperature < Channel8.MinTemperature) Channel8.MinTemperature = Channel8.Temperature;

                if (ChannelA.Temperature > ChannelA.MaxTemperature) ChannelA.MaxTemperature = ChannelA.Temperature;
                if (ChannelA.Temperature < ChannelA.MaxTemperature) ChannelA.MinTemperature = ChannelA.Temperature;



                Channel1.JunctionTemp = GetInternalTemp(Channel1.RawData);
                Channel2.JunctionTemp = GetInternalTemp(Channel2.RawData);
                Channel3.JunctionTemp = GetInternalTemp(Channel3.RawData);
                Channel4.JunctionTemp = GetInternalTemp(Channel4.RawData);
                Channel5.JunctionTemp = GetInternalTemp(Channel5.RawData);
                Channel6.JunctionTemp = GetInternalTemp(Channel6.RawData);
                Channel7.JunctionTemp = GetInternalTemp(Channel7.RawData);
                Channel8.JunctionTemp = GetInternalTemp(Channel8.RawData);

                Channel1.Fault = GetFaults(Channel1.RawData);
                Channel2.Fault = GetFaults(Channel2.RawData);
                Channel3.Fault = GetFaults(Channel3.RawData);
                Channel4.Fault = GetFaults(Channel4.RawData);
                Channel5.Fault = GetFaults(Channel5.RawData);
                Channel6.Fault = GetFaults(Channel6.RawData);
                Channel7.Fault = GetFaults(Channel7.RawData);
                Channel8.Fault = GetFaults(Channel8.RawData);

                if (DebugMode)
                {
                    textBoxFrameCheckSum.Text = ReceivedFrame[33].ToString();
                    textBoxCalcCheckSum.Text = CalculatedCheckSum.ToString();

                    Data1A.Text = ReceivedFrame[1].ToString();
                    Data1B.Text = ReceivedFrame[2].ToString();
                    Data1C.Text = ReceivedFrame[3].ToString();
                    Data1D.Text = ReceivedFrame[4].ToString();

                    Data2A.Text = ReceivedFrame[5].ToString();
                    Data2B.Text = ReceivedFrame[6].ToString();
                    Data2C.Text = ReceivedFrame[7].ToString();
                    Data2D.Text = ReceivedFrame[8].ToString();

                    Data3A.Text = ReceivedFrame[9].ToString();
                    Data3B.Text = ReceivedFrame[10].ToString();
                    Data3C.Text = ReceivedFrame[11].ToString();
                    Data3D.Text = ReceivedFrame[12].ToString();

                    Data4A.Text = ReceivedFrame[13].ToString();
                    Data4B.Text = ReceivedFrame[14].ToString();
                    Data4C.Text = ReceivedFrame[15].ToString();
                    Data4D.Text = ReceivedFrame[16].ToString();

                    Data5A.Text = ReceivedFrame[17].ToString();
                    Data5B.Text = ReceivedFrame[18].ToString();
                    Data5C.Text = ReceivedFrame[19].ToString();
                    Data5D.Text = ReceivedFrame[20].ToString();

                    Data6A.Text = ReceivedFrame[21].ToString();
                    Data6B.Text = ReceivedFrame[22].ToString();
                    Data6C.Text = ReceivedFrame[23].ToString();
                    Data6D.Text = ReceivedFrame[24].ToString();

                    Data7A.Text = ReceivedFrame[25].ToString();
                    Data7B.Text = ReceivedFrame[26].ToString();
                    Data7C.Text = ReceivedFrame[27].ToString();
                    Data7D.Text = ReceivedFrame[28].ToString();

                    Data8A.Text = ReceivedFrame[29].ToString();
                    Data8B.Text = ReceivedFrame[30].ToString();
                    Data8C.Text = ReceivedFrame[31].ToString();
                    Data8D.Text = ReceivedFrame[32].ToString();

                    CH1_Binary.Text = Convert.ToString(Channel1.RawData, 2).PadLeft(32, '0');
                    CH2_Binary.Text = Convert.ToString(Channel2.RawData, 2).PadLeft(32, '0');
                    CH3_Binary.Text = Convert.ToString(Channel3.RawData, 2).PadLeft(32, '0');
                    CH4_Binary.Text = Convert.ToString(Channel4.RawData, 2).PadLeft(32, '0');
                    CH5_Binary.Text = Convert.ToString(Channel5.RawData, 2).PadLeft(32, '0');
                    CH6_Binary.Text = Convert.ToString(Channel6.RawData, 2).PadLeft(32, '0');
                    CH7_Binary.Text = Convert.ToString(Channel7.RawData, 2).PadLeft(32, '0');
                    CH8_Binary.Text = Convert.ToString(Channel8.RawData, 2).PadLeft(32, '0');
                }
            }
            
            else{
                ErrorFrames++;
                labelErrors.Text = ErrorFrames.ToString();
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
            }
        }

        void UpdatePreview()
        {

            // Ambient
            if (ChannelA.ViewSetting == 0) CHA_Value.Text = Channel1.JunctionTemp.ToString() + " °C";
            else if (ChannelA.ViewSetting == 1) CHA_Value.Text = ChannelA.MaxTemperature.ToString() + " °C";
            else if (ChannelA.ViewSetting == 2) CHA_Value.Text = ChannelA.MinTemperature.ToString() + " °C";
            else if (ChannelA.ViewSetting == 3) CHA_Value.Text = ChannelA.AvgTemperature.ToString() + " °C";
            else CHA_Value.Text = "Error";



            // Channel 1
            switch (Channel1.Fault)
            {
                case 0:
                    groupBoxCH1.Enabled = true;
                    CH1_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH1_Value.ForeColor = Channel1.Color;

                    if(Channel1.ViewSetting == 0) CH1_Value.Text = Channel1.Temperature.ToString() + " °C";
                    else if(Channel1.ViewSetting == 1) CH1_Value.Text = Channel1.MaxTemperature.ToString() + " °C";
                    else if (Channel1.ViewSetting == 2) CH1_Value.Text = Channel1.MinTemperature.ToString() + " °C";
                    else if (Channel1.ViewSetting == 3) CH1_Value.Text = Channel1.AvgTemperature.ToString() + " °C";
                    else CH1_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH1.Enabled = false;
                    CH1_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH1_Value.ForeColor = System.Drawing.Color.Gray;
                    CH1_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH1.Enabled = true;
                    CH1_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH1_Value.ForeColor = System.Drawing.Color.Red;
                    CH1_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH1.Enabled = true;
                    CH1_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH1_Value.ForeColor = System.Drawing.Color.Red;
                    CH1_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 2
            switch (Channel2.Fault)
            {
                case 0:
                    groupBoxCH2.Enabled = true;
                    CH2_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH2_Value.ForeColor = Channel2.Color;

                    if (Channel2.ViewSetting == 0) CH2_Value.Text = Channel2.Temperature.ToString() + " °C";
                    else if (Channel2.ViewSetting == 1) CH2_Value.Text = Channel2.MaxTemperature.ToString() + " °C";
                    else if (Channel2.ViewSetting == 2) CH2_Value.Text = Channel2.MinTemperature.ToString() + " °C";
                    else if (Channel2.ViewSetting == 3) CH2_Value.Text = Channel2.AvgTemperature.ToString() + " °C";
                    else CH2_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH2.Enabled = false;
                    CH2_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH2_Value.ForeColor = System.Drawing.Color.Gray;
                    CH2_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH2.Enabled = true;
                    CH2_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH2_Value.ForeColor = System.Drawing.Color.Red;
                    CH2_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH2.Enabled = true;
                    CH2_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH2_Value.ForeColor = System.Drawing.Color.Red;
                    CH2_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 3
            switch (Channel3.Fault)
            {
                case 0:
                    groupBoxCH3.Enabled = true;
                    CH3_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH3_Value.ForeColor = Channel3.Color;

                    if (Channel3.ViewSetting == 0) CH3_Value.Text = Channel3.Temperature.ToString() + " °C";
                    else if (Channel3.ViewSetting == 1) CH3_Value.Text = Channel3.MaxTemperature.ToString() + " °C";
                    else if (Channel3.ViewSetting == 2) CH3_Value.Text = Channel3.MinTemperature.ToString() + " °C";
                    else if (Channel3.ViewSetting == 3) CH3_Value.Text = Channel3.AvgTemperature.ToString() + " °C";
                    else CH3_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH3.Enabled = false;
                    CH3_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH3_Value.ForeColor = System.Drawing.Color.Gray;
                    CH3_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH3.Enabled = true;
                    CH3_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH3_Value.ForeColor = System.Drawing.Color.Red;
                    CH3_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH3.Enabled = true;
                    CH3_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH3_Value.ForeColor = System.Drawing.Color.Red;
                    CH3_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 4
            switch (Channel4.Fault)
            {
                case 0:
                    groupBoxCH4.Enabled = true;
                    CH4_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH4_Value.ForeColor = Channel4.Color;

                    if (Channel4.ViewSetting == 0) CH4_Value.Text = Channel4.Temperature.ToString() + " °C";
                    else if (Channel4.ViewSetting == 1) CH4_Value.Text = Channel4.MaxTemperature.ToString() + " °C";
                    else if (Channel4.ViewSetting == 2) CH4_Value.Text = Channel4.MinTemperature.ToString() + " °C";
                    else if (Channel4.ViewSetting == 3) CH4_Value.Text = Channel4.AvgTemperature.ToString() + " °C";
                    else CH4_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH4.Enabled = false;
                    CH4_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH4_Value.ForeColor = System.Drawing.Color.Gray;
                    CH4_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH4.Enabled = true;
                    CH4_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH4_Value.ForeColor = System.Drawing.Color.Red;
                    CH4_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH4.Enabled = true;
                    CH4_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH4_Value.ForeColor = System.Drawing.Color.Red;
                    CH4_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 5
            switch (Channel5.Fault)
            {
                case 0:
                    groupBoxCH5.Enabled = true;
                    CH5_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH5_Value.ForeColor = Channel5.Color;

                    if (Channel5.ViewSetting == 0) CH5_Value.Text = Channel5.Temperature.ToString() + " °C";
                    else if (Channel5.ViewSetting == 1) CH5_Value.Text = Channel5.MaxTemperature.ToString() + " °C";
                    else if (Channel5.ViewSetting == 2) CH5_Value.Text = Channel5.MinTemperature.ToString() + " °C";
                    else if (Channel5.ViewSetting == 3) CH5_Value.Text = Channel5.AvgTemperature.ToString() + " °C";
                    else CH5_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH5.Enabled = false;
                    CH5_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH5_Value.ForeColor = System.Drawing.Color.Gray;
                    CH5_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH5.Enabled = true;
                    CH5_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH5_Value.ForeColor = System.Drawing.Color.Red;
                    CH5_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH5.Enabled = true;
                    CH5_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH5_Value.ForeColor = System.Drawing.Color.Red;
                    CH5_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 6
            switch (Channel6.Fault)
            {
                case 0:
                    groupBoxCH6.Enabled = true;
                    CH6_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH6_Value.ForeColor = Channel6.Color;

                    if (Channel6.ViewSetting == 0) CH6_Value.Text = Channel6.Temperature.ToString() + " °C";
                    else if (Channel6.ViewSetting == 1) CH6_Value.Text = Channel6.MaxTemperature.ToString() + " °C";
                    else if (Channel6.ViewSetting == 2) CH6_Value.Text = Channel6.MinTemperature.ToString() + " °C";
                    else if (Channel6.ViewSetting == 3) CH6_Value.Text = Channel6.AvgTemperature.ToString() + " °C";
                    else CH6_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH6.Enabled = false;
                    CH6_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH6_Value.ForeColor = System.Drawing.Color.Gray;
                    CH6_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH6.Enabled = true;
                    CH6_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH6_Value.ForeColor = System.Drawing.Color.Red;
                    CH6_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH6.Enabled = true;
                    CH6_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH6_Value.ForeColor = System.Drawing.Color.Red;
                    CH6_Value.Text = "VCC Short!";
                    break;
            }

            // Channel 7
            switch (Channel7.Fault)
            {
                case 0:
                    groupBoxCH7.Enabled = true;
                    CH7_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH7_Value.ForeColor = Channel7.Color;

                    if (Channel7.ViewSetting == 0) CH7_Value.Text = Channel7.Temperature.ToString() + " °C";
                    else if (Channel7.ViewSetting == 1) CH7_Value.Text = Channel7.MaxTemperature.ToString() + " °C";
                    else if (Channel7.ViewSetting == 2) CH7_Value.Text = Channel7.MinTemperature.ToString() + " °C";
                    else if (Channel7.ViewSetting == 3) CH7_Value.Text = Channel7.AvgTemperature.ToString() + " °C";
                    else CH7_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH7.Enabled = false;
                    CH7_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH7_Value.ForeColor = System.Drawing.Color.Gray;
                    CH7_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH7.Enabled = true;
                    CH7_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH7_Value.ForeColor = System.Drawing.Color.Red;
                    CH7_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH7.Enabled = true;
                    CH7_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH7_Value.ForeColor = System.Drawing.Color.Red;
                    CH7_Value.Text = "VCC Short!";
                    break;
            }


            // Channel 8
            switch (Channel8.Fault)
            {
                case 0:
                    groupBoxCH8.Enabled = true;
                    CH8_Value.TextAlign = ContentAlignment.MiddleRight;
                    CH8_Value.ForeColor = Channel8.Color;

                    if (Channel8.ViewSetting == 0) CH8_Value.Text = Channel8.Temperature.ToString() + " °C";
                    else if (Channel8.ViewSetting == 1) CH8_Value.Text = Channel8.MaxTemperature.ToString() + " °C";
                    else if (Channel8.ViewSetting == 2) CH8_Value.Text = Channel8.MinTemperature.ToString() + " °C";
                    else if (Channel8.ViewSetting == 3) CH8_Value.Text = Channel8.AvgTemperature.ToString() + " °C";
                    else CH8_Value.Text = "Error";
                    break;
                case 1:
                    groupBoxCH8.Enabled = false;
                    CH8_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH8_Value.ForeColor = System.Drawing.Color.Gray;
                    CH8_Value.Text = "N/C";
                    break;
                case 2:
                    groupBoxCH8.Enabled = true;
                    CH8_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH8_Value.ForeColor = System.Drawing.Color.Red;
                    CH8_Value.Text = "GND Short!";
                    break;
                case 3:
                    groupBoxCH8.Enabled = true;
                    CH8_Value.TextAlign = ContentAlignment.MiddleCenter;
                    CH8_Value.ForeColor = System.Drawing.Color.Red;
                    CH8_Value.Text = "VCC Short!";
                    break;
            }

        }


        uint GetFaults(Int32 Data)
        {
            if      ((Data & 0x0004) == 0x0004)  return 3;       // Thermocouple Short to VCC
            else if ((Data & 0x0002) == 0x0002)  return 2;       // Thermocouple Short to GND
            else if ((Data & 0x0001) == 0x0001)  return 1;       // Thermocouple is Open
            else return 0;                                       // ThermoCouple is Connected
        }


        decimal GetInternalTemp(Int32 Data)
        {
            decimal temperature = 0;
            Data = Data >> 4;
            temperature = (Data & 0x000007FF);
            if ((Data & 0x00000800) == 0x00000800)
            {
                Data = ~Data;
                temperature = Data & 0x000007FF;
                temperature += 1;
                temperature *= -1;
            }
            temperature = temperature * 0.0625m;
            temperature =  Math.Round(temperature, 2);
            return temperature;            
        }

        decimal GetThermocoupleTemp(Int32 Data)
        {
            decimal temperature = 0;
            Data = Data >> 18;
            temperature = (Data & 0x00001FFF);	
            if ((Data & 0x00002000) == 0x00002000)
            {
                Data = ~Data;
                temperature = Data & 0x00001FFF;
                temperature += 1;
                temperature *= -1;
            }
            temperature =  temperature*0.25m;
	        return temperature;
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendFrame_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#get_data\n");

            try
            {
                richTextBoxDebug.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCOMs.Text == "")
                {
                    textBox2.Text = "Please set te port";
                }
                else
                {
                    serialPort1.PortName = comboBoxCOMs.Text;
                    serialPort1.Open();
                    labelConnectionStatus.Text = "Connected";
                    labelConnectionStatus.ForeColor = System.Drawing.Color.Green;
                    buttonStart.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Unauthorized Acess";
                labelConnectionStatus.Text = "Disconnected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void CH1_Fault_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            Acquisition.Logging =  !Acquisition.Logging;
            timerLogg.Interval = Acquisition.Period;
            Acquisition.Countdown = Acquisition.Period;
            timer100ms.Enabled = !timer100ms.Enabled;
            timerLogg.Enabled = !timerLogg.Enabled;


            if (Acquisition.Logging == true)
            {
                if(Acquisition.Period < 50)
                {
                    timerRead.Interval = (int)Acquisition.Period;
                }

                buttonStart.Text = "Stop";
                buttonStart.BackColor = System.Drawing.Color.IndianRed;                

            }

            if (Acquisition.Logging == false)
            {
                timerRead.Interval = 50;
                buttonStart.Text = "Start";
                buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void buttonDebugMode_Click(object sender, EventArgs e)
        {
            DebugMode = !DebugMode;

            if (DebugMode == true)
            {
                buttonDebugMode.Text = "Disable Debug";
                buttonDebugMode.BackColor = System.Drawing.Color.IndianRed;

            }

            if (DebugMode == false)
            {
                buttonDebugMode.Text = "Enable Debug";
                buttonDebugMode.BackColor = System.Drawing.Color.PaleGreen;
            }

        }


        public void UpdateChart()
        {
            chart1.DataSource = Samples;

            if (Channel1.Fault == 0) checkBoxPlotCH1.Enabled = true;
                else checkBoxPlotCH1.Enabled = false;

            if (Channel2.Fault == 0) checkBoxPlotCH2.Enabled = true;
                else checkBoxPlotCH2.Enabled = false;

            if (Channel3.Fault == 0) checkBoxPlotCH3.Enabled = true;
                else checkBoxPlotCH3.Enabled = false;

            if (Channel4.Fault == 0) checkBoxPlotCH4.Enabled = true;
                else checkBoxPlotCH4.Enabled = false;

            if (Channel5.Fault == 0) checkBoxPlotCH5.Enabled = true;
                else checkBoxPlotCH5.Enabled = false;

            if (Channel6.Fault == 0) checkBoxPlotCH6.Enabled = true;
                else checkBoxPlotCH6.Enabled = false;

            if (Channel7.Fault == 0) checkBoxPlotCH7.Enabled = true;
                else checkBoxPlotCH7.Enabled = false;

            if (Channel8.Fault == 0) checkBoxPlotCH8.Enabled = true;
                else checkBoxPlotCH8.Enabled = false;


            if(Channel1.ShowOnScope) chart1.Series["CH1"].Enabled = true;
            else chart1.Series["CH1"].Enabled = false;

            if (Channel2.ShowOnScope) chart1.Series["CH2"].Enabled = true;
            else chart1.Series["CH2"].Enabled = false;

            if (Channel3.ShowOnScope) chart1.Series["CH3"].Enabled = true;
            else chart1.Series["CH3"].Enabled = false;

            if (Channel4.ShowOnScope) chart1.Series["CH4"].Enabled = true;
            else chart1.Series["CH4"].Enabled = false;

            if (Channel5.ShowOnScope) chart1.Series["CH5"].Enabled = true;
            else chart1.Series["CH5"].Enabled = false;

            if (Channel6.ShowOnScope) chart1.Series["CH6"].Enabled = true;
            else chart1.Series["CH6"].Enabled = false;

            if (Channel7.ShowOnScope) chart1.Series["CH7"].Enabled = true;
            else chart1.Series["CH7"].Enabled = false;

            if (Channel8.ShowOnScope) chart1.Series["CH8"].Enabled = true;
            else chart1.Series["CH8"].Enabled = false;



            chart1.Series["CH1"].Color = Channel1.Color;
            chart1.Series["CH2"].Color = Channel2.Color;
            chart1.Series["CH3"].Color = Channel3.Color;
            chart1.Series["CH4"].Color = Channel4.Color;
            chart1.Series["CH5"].Color = Channel5.Color;
            chart1.Series["CH6"].Color = Channel6.Color;
            chart1.Series["CH7"].Color = Channel7.Color;
            chart1.Series["CH8"].Color = Channel8.Color;

            chart1.DataBind();
            chart1.Update();

        }

        public void UpdateGridView()
        {
            dataGridView1.DataSource = typeof(Sample);
            dataGridView1.DataSource = Samples;
            dataGridView1.Update();
        }

        public void UpdateCounters()
        {

        }


        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            UpdatePreview();

            labelSamples.Text = ActualSampleNumber.ToString();

            Int32 TimeLeft = Acquisition.Countdown/100;
            Int32 MinLeft = (TimeLeft/600);
            Int32 SecLeft = TimeLeft - (600 * MinLeft); 

            labelTimeToNext.Text = MinLeft.ToString() + ":" + (SecLeft/10).ToString() + "." +(SecLeft % 10).ToString();
          //  labelTimeToNext.Text = TimeLeft.ToString();

            if (Acquisition.Logging)
            {

                UpdateChart();
                UpdateGridView();
            }
        }

        private void comboBoxColorCH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH1.Text;
            Color c = Color.FromName(n);           
            Channel1.Color = c;
            textBoxColorCH1.BackColor = Channel1.Color;
        }

        private void comboBoxColorCH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH2.Text;
            Color c = Color.FromName(n);
            Channel2.Color = c;
            textBoxColorCH2.BackColor = Channel2.Color;
        }

        private void comboBoxColorCH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH3.Text;
            Color c = Color.FromName(n);
            Channel3.Color = c;
            textBoxColorCH3.BackColor = Channel3.Color;
        }

        private void comboBoxColorCH4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH4.Text;
            Color c = Color.FromName(n);
            Channel4.Color = c;
            textBoxColorCH4.BackColor = Channel4.Color;
        }

        private void comboBoxColorCH5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH5.Text;
            Color c = Color.FromName(n);
            Channel5.Color = c;
            textBoxColorCH5.BackColor = Channel5.Color;
        }

        private void comboBoxColorCH6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH6.Text;
            Color c = Color.FromName(n);
            Channel6.Color = c;
            textBoxColorCH6.BackColor = Channel6.Color;
        }

        private void comboBoxColorCH7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH7.Text;
            Color c = Color.FromName(n);
            Channel7.Color = c;
            textBoxColorCH7.BackColor = Channel7.Color;
        }

        private void comboBoxColorCH8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxColorCH8.Text;
            Color c = Color.FromName(n);
            Channel8.Color = c;
            textBoxColorCH8.BackColor = Channel8.Color;
        }


        public void DefaultColors()
        {
            Channel1.Color = System.Drawing.Color.DarkGoldenrod;
            Channel2.Color = System.Drawing.Color.Firebrick;
            Channel3.Color = System.Drawing.Color.RoyalBlue;
            Channel4.Color = System.Drawing.Color.DarkMagenta;
            Channel5.Color = System.Drawing.Color.MediumSeaGreen;
            Channel6.Color = System.Drawing.Color.DimGray;
            Channel7.Color = System.Drawing.Color.DodgerBlue;
            Channel8.Color = System.Drawing.Color.MediumOrchid;

            textBoxColorCH1.BackColor = Channel1.Color;
            textBoxColorCH2.BackColor = Channel2.Color;
            textBoxColorCH3.BackColor = Channel3.Color;
            textBoxColorCH4.BackColor = Channel4.Color;
            textBoxColorCH5.BackColor = Channel5.Color;
            textBoxColorCH6.BackColor = Channel6.Color;
            textBoxColorCH7.BackColor = Channel7.Color;
            textBoxColorCH8.BackColor = Channel8.Color;

            comboBoxColorCH1.Text = Channel1.Color.Name.ToString();
            comboBoxColorCH2.Text = Channel2.Color.Name.ToString();
            comboBoxColorCH3.Text = Channel3.Color.Name.ToString();
            comboBoxColorCH4.Text = Channel4.Color.Name.ToString();
            comboBoxColorCH5.Text = Channel5.Color.Name.ToString();
            comboBoxColorCH6.Text = Channel6.Color.Name.ToString();
            comboBoxColorCH7.Text = Channel7.Color.Name.ToString();
            comboBoxColorCH8.Text = Channel8.Color.Name.ToString();


        }



        private void buttonDefaultColors_Click(object sender, EventArgs e)
        {
            DefaultColors();
        }






        private void CH_1_Act_Click(object sender, EventArgs e)
        {
            Channel1.ViewSetting = 0;
            CH_1_Act.BackColor = System.Drawing.Color.White;
            CH_1_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_1_Max_Click(object sender, EventArgs e)
        {
            Channel1.ViewSetting = 1;
            CH_1_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Max.BackColor = System.Drawing.Color.White;
            CH_1_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_1_Min_Click(object sender, EventArgs e)
        {
            Channel1.ViewSetting = 2;
            CH_1_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Min.BackColor = System.Drawing.Color.White;
            CH_1_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_1_Avg_Click(object sender, EventArgs e)
        {
            Channel1.ViewSetting = 3;
            CH_1_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_1_Avg.BackColor = System.Drawing.Color.White;
        }





        private void CH_2_Act_Click(object sender, EventArgs e)
        {
            Channel2.ViewSetting = 0;
            CH_2_Act.BackColor = System.Drawing.Color.White;
            CH_2_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_2_Max_Click(object sender, EventArgs e)
        {
            Channel2.ViewSetting = 1;
            CH_2_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Max.BackColor = System.Drawing.Color.White;
            CH_2_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_2_Min_Click(object sender, EventArgs e)
        {
            Channel2.ViewSetting = 2;
            CH_2_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Min.BackColor = System.Drawing.Color.White;
            CH_2_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_2_Avg_Click(object sender, EventArgs e)
        {
            Channel2.ViewSetting = 3;
            CH_2_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_2_Avg.BackColor = System.Drawing.Color.White;
        }



        private void CH_3_Act_Click(object sender, EventArgs e)
        {
            Channel3.ViewSetting = 0;
            CH_3_Act.BackColor = System.Drawing.Color.White;
            CH_3_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_3_Max_Click(object sender, EventArgs e)
        {
            Channel3.ViewSetting = 1;
            CH_3_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Max.BackColor = System.Drawing.Color.White;
            CH_3_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_3_Min_Click(object sender, EventArgs e)
        {
            Channel3.ViewSetting = 2;
            CH_3_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Min.BackColor = System.Drawing.Color.White;
            CH_3_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_3_Avg_Click(object sender, EventArgs e)
        {
            Channel3.ViewSetting = 3;
            CH_3_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_3_Avg.BackColor = System.Drawing.Color.White;
        }



        private void CH_4_Act_Click(object sender, EventArgs e)
        {
            Channel4.ViewSetting = 0;
            CH_4_Act.BackColor = System.Drawing.Color.White;
            CH_4_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_4_Max_Click(object sender, EventArgs e)
        {
            Channel4.ViewSetting = 1;
            CH_4_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Max.BackColor = System.Drawing.Color.White;
            CH_4_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_4_Min_Click(object sender, EventArgs e)
        {
            Channel4.ViewSetting = 2;
            CH_4_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Min.BackColor = System.Drawing.Color.White;
            CH_4_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_4_Avg_Click(object sender, EventArgs e)
        {
            Channel4.ViewSetting = 3;
            CH_4_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_4_Avg.BackColor = System.Drawing.Color.White;
        }



    
        private void CH_5_Act_Click(object sender, EventArgs e)
        {
            Channel5.ViewSetting = 0;
            CH_5_Act.BackColor = System.Drawing.Color.White;
            CH_5_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_5_Max_Click(object sender, EventArgs e)
        {
            Channel5.ViewSetting = 1;
            CH_5_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Max.BackColor = System.Drawing.Color.White;
            CH_5_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_5_Min_Click(object sender, EventArgs e)
        {
            Channel5.ViewSetting = 2;
            CH_5_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Min.BackColor = System.Drawing.Color.White;
            CH_5_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_5_Avg_Click(object sender, EventArgs e)
        {
            Channel5.ViewSetting = 3;
            CH_5_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_5_Avg.BackColor = System.Drawing.Color.White;
        }



        private void CH_6_Act_Click(object sender, EventArgs e)
        {
            Channel6.ViewSetting = 0;
            CH_6_Act.BackColor = System.Drawing.Color.White;
            CH_6_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_6_Max_Click(object sender, EventArgs e)
        {
            Channel6.ViewSetting = 1;
            CH_6_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Max.BackColor = System.Drawing.Color.White;
            CH_6_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_6_Min_Click(object sender, EventArgs e)
        {
            Channel6.ViewSetting = 2;
            CH_6_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Min.BackColor = System.Drawing.Color.White;
            CH_6_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_6_Avg_Click(object sender, EventArgs e)
        {
            Channel6.ViewSetting = 3;
            CH_6_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_6_Avg.BackColor = System.Drawing.Color.White;
        }




        private void CH_7_Act_Click(object sender, EventArgs e)
        {
            Channel7.ViewSetting = 0;
            CH_7_Act.BackColor = System.Drawing.Color.White;
            CH_7_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_7_Max_Click(object sender, EventArgs e)
        {
            Channel7.ViewSetting = 1;
            CH_7_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Max.BackColor = System.Drawing.Color.White;
            CH_7_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_7_Min_Click(object sender, EventArgs e)
        {
            Channel7.ViewSetting = 2;
            CH_7_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Min.BackColor = System.Drawing.Color.White;
            CH_7_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_7_Avg_Click(object sender, EventArgs e)
        {
            Channel7.ViewSetting = 3;
            CH_7_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_7_Avg.BackColor = System.Drawing.Color.White;
        }




        private void CH_8_Act_Click(object sender, EventArgs e)
        {
            Channel8.ViewSetting = 0;
            CH_8_Act.BackColor = System.Drawing.Color.White;
            CH_8_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_8_Max_Click(object sender, EventArgs e)
        {
            Channel8.ViewSetting = 1;
            CH_8_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Max.BackColor = System.Drawing.Color.White;
            CH_8_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_8_Min_Click(object sender, EventArgs e)
        {
            Channel8.ViewSetting = 2;
            CH_8_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Min.BackColor = System.Drawing.Color.White;
            CH_8_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_8_Avg_Click(object sender, EventArgs e)
        {
            Channel8.ViewSetting = 3;
            CH_8_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_8_Avg.BackColor = System.Drawing.Color.White;
        }




        private void CH_A_Act_Click(object sender, EventArgs e)
        {
            ChannelA.ViewSetting = 0;
            CH_A_Act.BackColor = System.Drawing.Color.White;
            CH_A_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_A_Max_Click(object sender, EventArgs e)
        {
            ChannelA.ViewSetting = 1;
            CH_A_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Max.BackColor = System.Drawing.Color.White;
            CH_A_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_A_Min_Click(object sender, EventArgs e)
        {
            ChannelA.ViewSetting = 2;
            CH_A_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Min.BackColor = System.Drawing.Color.White;
            CH_A_Avg.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void CH_A_Avg_Click(object sender, EventArgs e)
        {
            ChannelA.ViewSetting = 3;
            CH_A_Act.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Max.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Min.BackColor = System.Drawing.Color.Gainsboro;
            CH_A_Avg.BackColor = System.Drawing.Color.White;
        }


        private void textBoxNameCH1_TextChanged(object sender, EventArgs e)
        {
            Channel1.Name = textBoxNameCH1.Text;
            groupBoxCH1.Text = "CH1 - " + Channel1.Name;
        }


        private void textBoxNameCH2_TextChanged(object sender, EventArgs e)
        {
            Channel2.Name = textBoxNameCH2.Text;
            groupBoxCH2.Text = "CH2 - " + Channel2.Name;
        }

        private void textBoxNameCH3_TextChanged(object sender, EventArgs e)
        {
            Channel3.Name = textBoxNameCH3.Text;
            groupBoxCH3.Text = "CH3 - " + Channel3.Name;

        }

        private void textBoxNameCH4_TextChanged(object sender, EventArgs e)
        {
            Channel4.Name = textBoxNameCH4.Text;
            groupBoxCH4.Text = "CH4 - " + Channel4.Name;
        }

        private void textBoxNameCH5_TextChanged(object sender, EventArgs e)
        {
            Channel5.Name = textBoxNameCH5.Text;
            groupBoxCH5.Text = "CH5 - " + Channel5.Name;
        }

        private void textBoxNameCH6_TextChanged(object sender, EventArgs e)
        {
            Channel6.Name = textBoxNameCH6.Text;
            groupBoxCH6.Text = "CH6 - " + Channel6.Name;
        }

        private void textBoxNameCH7_TextChanged(object sender, EventArgs e)
        {
            Channel7.Name = textBoxNameCH7.Text;
            groupBoxCH7.Text = "CH7 - " + Channel7.Name;
        }

        private void textBoxNameCH8_TextChanged(object sender, EventArgs e)
        {
            Channel8.Name = textBoxNameCH8.Text;
            groupBoxCH8.Text = "CH8 - " + Channel8.Name;
        }


        void ClearChannelNames()
        {

            Channel1.Name = "";
            Channel2.Name = "";
            Channel3.Name = "";
            Channel4.Name = "";
            Channel5.Name = "";
            Channel6.Name = "";
            Channel7.Name = "";
            Channel8.Name = "";

            textBoxNameCH1.Text = "";
            textBoxNameCH2.Text = "";
            textBoxNameCH3.Text = "";
            textBoxNameCH4.Text = "";
            textBoxNameCH5.Text = "";
            textBoxNameCH6.Text = "";
            textBoxNameCH7.Text = "";
            textBoxNameCH8.Text = "";

            groupBoxCH1.Text = "CH1 - " + Channel1.Name;
            groupBoxCH2.Text = "CH2 - " + Channel2.Name;
            groupBoxCH3.Text = "CH3 - " + Channel3.Name;
            groupBoxCH4.Text = "CH4 - " + Channel4.Name;
            groupBoxCH5.Text = "CH5 - " + Channel5.Name;
            groupBoxCH6.Text = "CH6 - " + Channel6.Name;
            groupBoxCH7.Text = "CH7 - " + Channel7.Name;
            groupBoxCH8.Text = "CH8 - " + Channel8.Name;

        }

        private void buttonClearNames_Click(object sender, EventArgs e)
        {
            ClearChannelNames();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {

            foreach ( Sample aSample in Samples)
            {
                richTextBoxTests.Text = aSample.ToString();
            }

        }

        private void x_Click(object sender, EventArgs e)
        {
            registerData();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void periodmSec_ValueChanged(object sender, EventArgs e)
        {
            Acquisition.mSec = periodmSec.Value;
            Acquisition.CalculatePeriod();

        }

        private void periodSec_ValueChanged(object sender, EventArgs e)
        {
            Acquisition.Sec = periodSec.Value;
            Acquisition.CalculatePeriod();
        }

        private void periodMin_ValueChanged(object sender, EventArgs e)
        {
            Acquisition.Min = periodMin.Value;
            Acquisition.CalculatePeriod();

        }

        private void timerLogg_Tick(object sender, EventArgs e)
        {
            registerData();
            Acquisition.Countdown = Acquisition.Period;

        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void a(object sender, EventArgs e)
        {
            Acquisition.Countdown = Acquisition.Countdown - 100;
        }

        private void checkBoxPlotCH1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH1.Checked && checkBoxPlotCH1.Enabled) Channel1.ShowOnScope = true;
            else Channel1.ShowOnScope = false;
        }

        private void checkBoxPlotCH2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH2.Checked && checkBoxPlotCH2.Enabled) Channel2.ShowOnScope = true;
            else Channel2.ShowOnScope = false;
        }

        private void checkBoxPlotCH3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH3.Checked && checkBoxPlotCH3.Enabled) Channel3.ShowOnScope = true;
            else Channel3.ShowOnScope = false;
        }

        private void checkBoxPlotCH4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH4.Checked && checkBoxPlotCH4.Enabled) Channel4.ShowOnScope = true;
            else Channel4.ShowOnScope = false;
        }

        private void checkBoxPlotCH5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH5.Checked && checkBoxPlotCH5.Enabled) Channel5.ShowOnScope = true;
            else Channel5.ShowOnScope = false;
        }

        private void checkBoxPlotCH6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH6.Checked && checkBoxPlotCH6.Enabled) Channel6.ShowOnScope = true;
            else Channel6.ShowOnScope = false;
        }

        private void checkBoxPlotCH7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH7.Checked && checkBoxPlotCH7.Enabled) Channel7.ShowOnScope = true;
            else Channel7.ShowOnScope = false;
        }

        private void checkBoxPlotCH8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlotCH8.Checked && checkBoxPlotCH8.Enabled) Channel8.ShowOnScope = true;
            else Channel8.ShowOnScope = false;
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Maximum = (double)Channel1.MaxTemperature + 1;
            chart1.ChartAreas[0].AxisY.Minimum = (double)Channel1.MinTemperature - 1;
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save the data before clearing it?", "", 
            MessageBoxButtons.YesNoCancel);

        }
    }
}
