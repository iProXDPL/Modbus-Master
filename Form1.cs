using System;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace Lab_5__Modbus_
{
    public partial class Form1 : Form
    {
        public static SerialPort _serialport = new SerialPort();
        public System.Windows.Forms.Timer[] timerList = new System.Windows.Forms.Timer[100];
        public int timerMaxIndex = -1;
        public int mainrefresh;
        public static Socket mSocket;
        public Form1()
        {
            InitializeComponent();
            comboBoxPorty.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBaudRate.SelectedIndex = 4;
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopbits.SelectedIndex = 1;
            comboBoxPorty.SelectedIndex = 0;
            Function.SelectedIndex = 0;
            RTUSelect.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        private void RTUSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (RTUSelect.Checked)
            {
                comboBoxPorty.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxParity.Enabled = true;
                comboBoxStopbits.Enabled = true;
            }
            else
            {
                comboBoxPorty.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                comboBoxParity.Enabled = false;
                comboBoxStopbits.Enabled = false;
            }
        }
        private void TCPSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (TCPSelect.Checked)
            {
                TCPIP.Enabled = true;
                TCPPort.Enabled = true;
            }
            else
            {
                TCPIP.Enabled = false;
                TCPPort.Enabled = false;
            }
        }
        private void RefreshComs_Click(object sender, EventArgs e)
        {
            comboBoxPorty.Items.Clear();
            comboBoxPorty.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPorty.SelectedIndex = 0;
        }
        private void Connect_BTNClick(object sender, EventArgs e)
        {
            Connect_Click();
        }
        private void Disconnect_BTNClick(object sender, EventArgs e)
        {
            Disconnect_Click();
        }
        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            ClearInterval(mainrefresh);
            DebugBox.AppendText("Zmianna \r\n");
            DebugBox.AppendText("------- \r\n");
            ushort Regval = Convert.ToUInt16(RegValue.Value);
            ushort WartoscV = Convert.ToUInt16(WartoscValue.Value);
            ushort WartoscB;
            if (Convert.ToUInt32(WartoscValue.Value) >= 1)
            {
                WartoscB = 65280;
            }
            else
            {
                WartoscB = 0;
            }
            WartoscB = Convert.ToUInt16(WartoscB);
            byte device = Convert.ToByte(Device.Value);
            int intfun = (Function.SelectedIndex + 1);

            byte[] f;
            if (RTUSelect.Checked)
            {
                switch (intfun)
                {
                    case 1:
                        //force coil
                        f = FramemakerRTU(device, Convert.ToByte(5), Regval, WartoscB);
                        _serialport.Write(f, 0, f.Length);
                        DebugBox.AppendText(String.Format("TX: "));
                        foreach (var b in f)
                        {
                            DebugBox.AppendText(String.Format("{0:X2}", b));
                        }
                        DebugBox.AppendText(String.Format("\r\n"));
                        WaitForCallbackFrame();
                        break;
                    case 3:
                        //force reg
                        f = FramemakerRTU(device, Convert.ToByte(6), Regval, WartoscV);
                        _serialport.Write(f, 0, f.Length);
                        DebugBox.AppendText(String.Format("TX: "));
                        foreach (var b in f)
                        {
                            DebugBox.AppendText(String.Format("{0:X2}", b));
                        }
                        DebugBox.AppendText(String.Format("\r\n"));
                        WaitForCallbackFrame();
                        break;
                }
            }
            else if (TCPSelect.Checked)
            {
                switch (intfun)
                {
                    case 1:
                        //force coil
                        f = FramemakerTCP(Convert.ToByte(5), device, Convert.ToByte(5), Regval, WartoscB);
                        mSocket.Send(f, f.Length, SocketFlags.None);
                        DebugBox.AppendText(String.Format("TX: "));
                        foreach (var b in f)
                        {
                            DebugBox.AppendText(String.Format("{0:X2}", b));
                        }
                        DebugBox.AppendText(String.Format("\r\n"));
                        WaitForCallbackFrame();
                        break;
                    case 3:
                        //force reg
                        f = FramemakerTCP(Convert.ToByte(6), device, Convert.ToByte(6), Regval, WartoscV);
                        mSocket.Send(f, f.Length, SocketFlags.None);
                        DebugBox.AppendText(String.Format("TX: "));
                        foreach (var b in f)
                        {
                            DebugBox.AppendText(String.Format("{0:X2}", b));
                        }
                        DebugBox.AppendText(String.Format("\r\n"));
                        WaitForCallbackFrame();
                        break;
                }
            }
        }
        private void WaitForCallbackFrame()
        {
            int refreshtime = (Convert.ToInt32(TimeRefresh.Text));
            if (RTUSelect.Checked)
            {
                int totalBytes = _serialport.BytesToRead;
                if (totalBytes > 9)
                {
                    byte[] msg = new byte[totalBytes];
                    _serialport.Read(msg, 0, msg.Length);
                    DebugBox.AppendText(String.Format("RX: "));
                    for (int m = 0; m < msg.Length; m++)
                    {
                        DebugBox.AppendText(String.Format("{0:X2}", msg[m]));
                    }
                    DebugBox.AppendText(String.Format("\r\n"));
                    DebugBox.AppendText(String.Format("------- \r\n"));
                    mainrefresh = SetInterval(refreshtime, MainprogRTU);
                }
                else
                {
                    WaitForCallbackFrame();
                }
            }
            else if (TCPSelect.Checked)
            {
                byte[] buf = ReadTCP();
                if (buf.Length > 9)
                {
                    DebugBox.AppendText(String.Format("RX: "));
                    foreach (var b in buf)
                    {
                        DebugBox.AppendText(String.Format("{0:X2}", b));
                    }
                    DebugBox.AppendText(String.Format("\r\n"));
                    DebugBox.AppendText(String.Format("------- \r\n"));
                    mainrefresh = SetInterval(refreshtime, MainprogTCP);
                }
                else
                {
                    WaitForCallbackFrame();
                }
            }
        }
        private void SavetoFileMenuStrip_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("s").Replace(":", ".");
            string path = @"Zapis " + data + ".txt";
            int column = DataGrid.Columns.Count;
            int row = DataGrid.Rows.Count;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    for (int r = 0; r < row; r++)
                    {
                        for (int c = 0; c < column; c++)
                        {
                            sw.Write(DataGrid.Rows[r].Cells[c].Value.ToString() + " ");
                        }
                        sw.WriteLine("");
                    }
                    sw.Close();
                }
            }
        }
        private void PolaczMenu_Click(object sender, EventArgs e)
        {
            Connect_Click();
        }
        private void RozlaczMenu_Click(object sender, EventArgs e)
        {
            Disconnect_Click();
        }
        public void Connect_Click()
        {
            int refreshtime = (Convert.ToInt32(TimeRefresh.Text));
            if (RTUSelect.Checked)
            {
                if (!_serialport.IsOpen)
                {
                    try
                    {
                        _serialport.PortName = comboBoxPorty.Text;
                        _serialport.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                        _serialport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopbits.Text);
                        _serialport.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                        int timeout = (Convert.ToInt32(Timeout.Text));
                        _serialport.ReadTimeout = timeout;
                        _serialport.WriteTimeout = timeout;
                        _serialport.Open();
                        if (_serialport.IsOpen)
                        {
                            RTUSelect.Enabled = false;
                            TCPSelect.Enabled = false;
                            ProgressBar.Value = 100;
                            ProgressLabel.Text = "Połaczone";
                            TextConnect.Text = comboBoxPorty.Text + " " + comboBoxBaudRate.Text;
                            Connect.Enabled = false;
                            polaczMenuClick.Enabled = false;
                            rozlaczMenuClick.Enabled = true;
                            Disconnect.Enabled = true;
                            mainrefresh = SetInterval(refreshtime, MainprogRTU);
                        }
                    }
                    catch (Exception ex)
                    {
                        _serialport.Close();
                        ClearInterval(mainrefresh);
                        ProgressLabel.Text = "Rozłączone";
                        ProgressBar.Value = 0;
                        TextConnect.Text = "Error serial port :: " + ex.Message;
                    }
                }
            }
            else if (TCPSelect.Checked)
            {
                string IP = TCPIP.Text;
                short Port = Convert.ToInt16(TCPPort.Text);
                mSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveBufferSize = 256,
                    SendBufferSize = 256
                };
                IPEndPoint server = new IPEndPoint(IPAddress.Parse(IP), Port);
                mSocket.Connect(server);
                if (!Convert.IsDBNull(mSocket))
                {
                    RTUSelect.Enabled = false;
                    TCPSelect.Enabled = false;
                    ProgressBar.Value = 100;
                    ProgressLabel.Text = "Połaczone";
                    TextConnect.Text = TCPIP.Text + " " + TCPPort.Text;
                    Connect.Enabled = false;
                    polaczMenuClick.Enabled = false;
                    rozlaczMenuClick.Enabled = true;
                    Disconnect.Enabled = true;
                    mainrefresh = SetInterval(refreshtime, MainprogTCP);
                }
            }
        }
        public void Disconnect_Click()
        {
            if (_serialport.IsOpen)
            {
                RTUSelect.Enabled = true;
                TCPSelect.Enabled = true;
                ClearInterval(mainrefresh);
                ProgressLabel.Text = "Rozłączone";
                ProgressBar.Value = 0;
                TextConnect.Text = "-";
                Connect.Enabled = true;
                polaczMenuClick.Enabled = true;
                rozlaczMenuClick.Enabled = false;
                Disconnect.Enabled = false;
                _serialport.Close();
            }
            else if (!Convert.IsDBNull(mSocket))
            {
                RTUSelect.Enabled = true;
                TCPSelect.Enabled = true;
                ClearInterval(mainrefresh);
                ProgressLabel.Text = "Rozłączone";
                ProgressBar.Value = 0;
                TextConnect.Text = "-";
                Connect.Enabled = true;
                polaczMenuClick.Enabled = true;
                rozlaczMenuClick.Enabled = false;
                Disconnect.Enabled = false;
                mSocket.Close();
            }
        }
        private byte[] ReadTCP()
        {
            byte[] result = new byte[mSocket.ReceiveBufferSize];
            NetworkStream ns = new NetworkStream(mSocket);
            if (ns.CanRead)
            {
                mSocket.Receive(result, result.Length, SocketFlags.None);
            }
            return result;
        }
        private void MainprogTCP() 
        {
            byte device = Convert.ToByte(Device.Value);
            int intfun = (Function.SelectedIndex + 1);
            byte fun = Convert.ToByte(intfun);
            ushort id = Convert.ToUInt16(intfun);
            ushort address = Convert.ToUInt16(Adres.Value);
            int addressint = Convert.ToInt32(Adres.Value);
            ushort ilosc = Convert.ToUInt16(LengthRead.Value);
            int dlugosc = Convert.ToInt32(LengthRead.Value);
            if (Convert.IsDBNull(mSocket))
            {
                RTUSelect.Enabled = true;
                TCPSelect.Enabled = true;
                ClearInterval(mainrefresh);
                ProgressLabel.Text = "Rozłączone";
                ProgressBar.Value = 0;
                TextConnect.Text = "-";
                Connect.Enabled = true;
                Disconnect.Enabled = false;
                mSocket.Close();
                return;
            }
            byte[] frame = FramemakerTCP(id, device, fun, address, ilosc);
            mSocket.Send(frame, frame.Length, SocketFlags.None);
            DebugBox.AppendText(String.Format("TX: "));
            foreach (var f in frame)
            {
                DebugBox.AppendText(String.Format("{0:X2}", f));
            }
            DebugBox.AppendText(String.Format("\r\n"));

            byte[] buf = ReadTCP();
            DebugBox.AppendText(String.Format("RX: "));
            foreach (var b in buf)
            {
                DebugBox.AppendText(String.Format("{0:X2}", b));
            }
            DebugBox.AppendText(String.Format("\r\n"));

            if (Convert.IsDBNull(buf))
            {
                return;
            }
            if (buf.Length > 9)
            {
                if (buf[1] != 1 && buf[1] != 2 && buf[1] != 3 && buf[1] != 4)
                {
                    DataGrid.Rows.Clear();
                    DebugBox.AppendText(String.Format("Illegal Function {0}\r\n", buf[7]));
                    DebugBox.AppendText(String.Format("\r\n"));
                    return;
                }
                switch (intfun)
                {
                    case 1:
                        //Coils
                        bool[] Coils = new bool[dlugosc];
                        for (int i = 0; i < Coils.Length; i++)
                        {
                            int intData = buf[9 + i / 8];
                            int mask = Convert.ToInt32(Math.Pow(2, (i % 8)));
                            Coils[i] = Convert.ToBoolean((intData & mask) / mask);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < Coils.Length; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, String.Format("{0}", Coils[i]));
                        }
                        break;
                    case 2:
                        //Inputs
                        bool[] Inputs = new bool[dlugosc];
                        for (int i = 0; i < Inputs.Length; i++)
                        {
                            int intData = buf[9 + i / 8];
                            int mask = Convert.ToInt32(Math.Pow(2, (i % 8)));
                            Inputs[i] = Convert.ToBoolean((intData & mask) / mask);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < Inputs.Length; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, String.Format("{0}", Inputs[i]));
                        }
                        break;
                    case 3:
                        //Handling register
                        ushort[] Handling = new ushort[dlugosc];
                        for (int i = 0; i < dlugosc; i++)
                        {
                            Handling[i] = (ushort)(buf[9 + i * 2] << 8 | buf[10 + i * 2]);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < Handling.Length; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, String.Format("{0}", Handling[i]));
                        }
                        break;
                    case 4:
                        //Input Registers
                        ushort[] Input = new ushort[dlugosc];
                        for (int i = 0; i < dlugosc; i++)
                        {
                            Input[i] = (ushort)(buf[9 + i * 2] << 8 | buf[10 + i * 2]);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < dlugosc; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, Input[i]);
                        }
                        break;
                }
            }
        }
        private void MainprogRTU()
        {
            byte device = Convert.ToByte(Device.Value);
            int intfun = (Function.SelectedIndex + 1);
            byte fun = Convert.ToByte(intfun);
            int addressint = Convert.ToInt32(Adres.Value);
            ushort address = Convert.ToUInt16(Adres.Value);
            int dlugosc = Convert.ToInt32(LengthRead.Value);
            ushort ilosc = Convert.ToUInt16(LengthRead.Value);
            byte[] frame = FramemakerRTU(device, fun, address, ilosc);
            _serialport.Write(frame, 0, frame.Length);
            DebugBox.AppendText(String.Format("TX: "));
            foreach (var f in frame)
            {
                DebugBox.AppendText(String.Format("{0:X2}", f));
            }
            DebugBox.AppendText(String.Format("\r\n"));
            int totalBytes = _serialport.BytesToRead;
            if (totalBytes > 7)
            {
                byte[] msg = new byte[totalBytes];
                _serialport.Read(msg, 0, msg.Length);
                DebugBox.AppendText(String.Format("RX: "));
                for (int m = 0; m < msg.Length; m++)
                {
                    DebugBox.AppendText(String.Format("{0:X2}", msg[m]));
                }
                DebugBox.AppendText(String.Format("\r\n"));
                if (msg[1] != 1 && msg[1] != 2 && msg[1] != 3 && msg[1] != 4)
                {
                    DataGrid.Rows.Clear();
                    DebugBox.AppendText(String.Format("Illegal Function {0}\r\n", msg[1]));
                    DebugBox.AppendText(String.Format("\r\n"));
                    return;
                }
                switch (intfun)
                {
                    case 1:
                        //Coils
                        bool[] Coils = new bool[dlugosc];
                        for (int i = 0; i < Coils.Length; i++)
                        {
                            int intData = msg[3 + i / 8];
                            int mask = Convert.ToInt32(Math.Pow(2, (i % 8)));
                            Coils[i] = Convert.ToBoolean((intData & mask) / mask);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < Coils.Length; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, String.Format("{0}", Coils[i]));
                        }
                        break;
                    case 2:
                        //Inputs
                        bool[] Inputs = new bool[dlugosc];
                        for (int i = 0; i < Inputs.Length; i++)
                        {
                            int intData = msg[3 + i / 8];
                            int mask = Convert.ToInt32(Math.Pow(2, (i % 8)));
                            Inputs[i] = Convert.ToBoolean((intData & mask) / mask);
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < Inputs.Length; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, String.Format("{0}", Inputs[i]));
                        }
                        break;
                    case 3:
                        //Handling register
                        ushort[] Handling = new ushort[dlugosc];
                        for (int i = 0; i < dlugosc; i++)
                        {
                            if (dlugosc != 1 && (((msg.Length - 5) / 2) != dlugosc || ((totalBytes - 5) / 2) != dlugosc))
                            {
                                DebugBox.AppendText(String.Format("Wrong Frame \r\n"));
                                DebugBox.AppendText(String.Format("\r\n"));
                                return;
                            }
                            byte lowByte;
                            byte highByte;
                            highByte = msg[3 + i * 2];
                            lowByte = msg[3 + i * 2 + 1];

                            msg[3 + i * 2] = lowByte;
                            msg[3 + i * 2 + 1] = highByte;

                            Handling[i] = BitConverter.ToUInt16(msg, (3 + i * 2));
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < dlugosc; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, Handling[i]);
                        }
                        break;
                    case 4:
                        //Input Registers
                        ushort[] Input = new ushort[dlugosc];
                        for (int i = 0; i < dlugosc; i++)
                        {
                            if (dlugosc!=1 && (((msg.Length - 5) / 2) != dlugosc || ((totalBytes - 5) / 2) != dlugosc))
                            {
                                DebugBox.AppendText(String.Format("Wrong Frame \r\n"));
                                DebugBox.AppendText(String.Format("\r\n"));
                                return;
                            }
                            byte lowByte;
                            byte highByte;
                            highByte = msg[3 + i * 2];
                            lowByte = msg[3 + i * 2 + 1];

                            msg[3 + i * 2] = lowByte;
                            msg[3 + i * 2 + 1] = highByte;

                            Input[i] = BitConverter.ToUInt16(msg, (3 + i * 2));
                        }
                        DataGrid.Rows.Clear();
                        for (int i = 0; i < dlugosc; i++)
                        {
                            int realid = i + addressint;
                            DataGrid.Rows.Add(realid, Input[i]);
                        }
                        break;
                }
            }
        }
        private static byte[] FramemakerTCP(ushort id, byte device, byte fun, ushort address, ushort ilosc)
        {
            byte[] frame = new byte[12];
            frame[0] = (byte)(id / 256);
            frame[1] = (byte)(id % 256);
            frame[2] = 0;
            frame[3] = 0;
            frame[4] = 0;
            frame[5] = 6;
            frame[6] = device;
            frame[7] = fun;
            frame[8] = (byte)(address >> 8);
            frame[9] = (byte)address;
            frame[10] = (byte)(ilosc >> 8);
            frame[11] = (byte)ilosc;
            return frame;
        }
        private static byte[] FramemakerRTU(byte device, byte fun, ushort address, ushort ilosc)
        {
            byte[] frame = new byte[8];
            frame[0] = device;
            frame[1] = fun;
            frame[2] = (byte)(address >> 8);
            frame[3] = (byte)address;
            frame[4] = (byte)(ilosc >> 8);
            frame[5] = (byte)ilosc;
            byte[] cheakSum = CRC16(frame);
            frame[6] = cheakSum[0];
            frame[7] = cheakSum[1];
            return frame;
        }
        private static byte[] CRC16(byte[] data)
        {
            byte[] checkSum = new byte[2];
            ushort reg_crc = 0XFFFF;
            for (int i = 0; i < data.Length - 2; i++)
            {
                reg_crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((reg_crc & 0x01) == 1)
                    {
                        reg_crc = (ushort)((reg_crc >> 1) ^ 0xA001);
                    }
                    else
                    {
                        reg_crc = (ushort)(reg_crc >> 1);
                    }
                }
            }
            checkSum[1] = (byte)((reg_crc >> 8) & 0xFF);
            checkSum[0] = (byte)(reg_crc & 0xFF);
            return checkSum;
        }
        public void ClearInterval(int interval)
        {
            if (timerList[interval] == null)
                return;

            timerList[interval].Stop();
            timerList[interval] = null;
            if (interval == timerMaxIndex)
                timerMaxIndex--;
        }
        public int SetInterval(int time, Action function)
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer
            {
                Interval = time
            };
            tmr.Tick += new EventHandler(delegate (object s, EventArgs ev)
            {
                function();
            });
            tmr.Start();

            timerMaxIndex++;
            var index = timerMaxIndex;
            timerList[timerMaxIndex] = tmr;
            return index;
        }
    }
}
