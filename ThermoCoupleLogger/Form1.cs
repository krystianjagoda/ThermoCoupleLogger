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

        public bool Logging = false;

        public Form1()
        {
            InitializeComponent();
            serialPort1.ReadTimeout = 2000; // Read Timeout = 2s
            getAvailablePorts();
            tryToConnect();
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
                timer2.Enabled = true;
            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Unauthorized Acess";
                labelConnectionStatus.Text = "Disconnected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Maroon;
                timer2.Enabled = false;
            }
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
                    if(i < 33)
                    {
                        Sum = Sum + (Int32)ReceivedFrame[i];
                    }
                    
                }
                
            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }

            CalculatedCheckSum = Sum % 255;

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

            textBoxFrameCheckSum.Text = ReceivedFrame[33].ToString();
            textBoxCalcCheckSum.Text = CalculatedCheckSum.ToString();

            Int32 Decimal = ((Int32)ReceivedFrame[1] << 24) + ((Int32)ReceivedFrame[2] << 16) + ((Int32)ReceivedFrame[3] << 8) + ReceivedFrame[4];
            CH1_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            CH1_Value.Text = GetThermocoupleTemp(Decimal).ToString() + " C°";

            Decimal = ((Int32)ReceivedFrame[5] << 24) + ((Int32)ReceivedFrame[6] << 16) + ((Int32)ReceivedFrame[7] << 8) + ReceivedFrame[8];
            CH2_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[9] << 24) + ((Int32)ReceivedFrame[10] << 16) + ((Int32)ReceivedFrame[11] << 8) + ReceivedFrame[12];
            CH3_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[13] << 24) + ((Int32)ReceivedFrame[14] << 16) + ((Int32)ReceivedFrame[15] << 8) + ReceivedFrame[16];
            CH4_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[17] << 24) + ((Int32)ReceivedFrame[18] << 16) + ((Int32)ReceivedFrame[19] << 8) + ReceivedFrame[20];
            CH5_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[21] << 24) + ((Int32)ReceivedFrame[22] << 16) + ((Int32)ReceivedFrame[23] << 8) + ReceivedFrame[24];
            CH6_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[25] << 24) + ((Int32)ReceivedFrame[26] << 16) + ((Int32)ReceivedFrame[27] << 8) + ReceivedFrame[28];
            CH7_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');

            Decimal = ((Int32)ReceivedFrame[29] << 24) + ((Int32)ReceivedFrame[30] << 16) + ((Int32)ReceivedFrame[31] << 8) + ReceivedFrame[32];
            CH8_Binary.Text = Convert.ToString(Decimal, 2).PadLeft(32, '0');



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
            Logging = !Logging;
            timer1.Enabled = !timer1.Enabled;

            if (Logging == true)
            {
                buttonStart.Text = "Stop";
                buttonStart.BackColor = System.Drawing.Color.IndianRed;

            }

            if (Logging == false)
            {
                buttonStart.Text = "Start";
                buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getData();
        }
    }
}
