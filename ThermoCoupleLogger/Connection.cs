using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ThermoCoupleLogger
{
    public class Connection
    {
        public Connection(){
            ports = SerialPort.GetPortNames();
        }

        public String[] ports;

        public bool ConnectionStatus = false;  // true = connected, false = disconnected
        public string ActualPort = "NONE";



        public int BaudRate = 115200;

    }
}
