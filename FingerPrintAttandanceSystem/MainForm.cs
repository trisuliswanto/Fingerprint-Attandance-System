using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Data.SQLite;

namespace FingerPrintAttandanceSystem
{
    public partial class MainForm : Form
    {
        NumberFormatInfo provider = new NumberFormatInfo();
        IController msgController;
        int msgValue;

        public MainForm()
        {
            InitializeComponent();
            SerialPort ComPort = new SerialPort();
            StatusLabel.Text = "Disconnected";
            msgValue = 0;
        }

        void update_port()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            //string ComPortName = null;
            portname.Items.Clear();

            ArrayComPortsNames = SerialPort.GetPortNames();
            foreach (string port in ArrayComPortsNames)
            {
                index += 1;
                portname.Items.Add(ArrayComPortsNames[index]);
            }
            if (index >= 0) portname.Text = ArrayComPortsNames[0];

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //sevenSegmentArray1.ArrayCount = 8;
            update_port();
            provider.NumberDecimalSeparator = ".";

            this.msgController = new Controller();
            this.msgController.ControllerEvent += new MessageDelegate(msgController_ControllerEvent);
        }

        // this is the method being called.
        void msgController_ControllerEvent(object sender, MessageEventArgs e)
        {
            this.msgValue += 1;
            this.StatusLabel.Text = e.Message + " " + this.msgValue.ToString();
        }

        private void portname_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) update_port();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a new database connection:
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");

            // open the connection:
            //SQLiteCommand 
            sqlite_conn.Open();

            var form = new LoginForm();
            DialogResult dialogResult = form.ShowDialog(this); // if you need non-modal window

            if(dialogResult == DialogResult.OK)
            {
                DataSiswa childForm = new DataSiswa(this.msgController);
                childForm.Show();
            }
        }

        private void Connect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(serialPort1.IsOpen))
                {
                    if (portname.Text == "")
                    {
                        serialPort1.PortName = "COM PORT";
                    }
                    else
                    {
                        serialPort1.PortName = Convert.ToString(portname.Text);
                    }

                    serialPort1.BaudRate = Convert.ToInt32("115200");

                    serialPort1.Open();
                    //Connect.Image = ((System.Drawing.Image)(Properties.Resources.dark_disconnect_icon));
                    Connect.Text = "DISCONNECT";

                    StatusLabel.Text = "Connected to " + portname.Text;
                    portname.Enabled = false;

                }

                else if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    Connect.Text = "CONNECT";
                    StatusLabel.Text = "Disconnected";
                    portname.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Terjadi Kesalahan!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            this.msgController.ControllerEvent -= msgController_ControllerEvent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.msgController.InvokeControllerEvent("Form1 fired the event. ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSiswa childForm = new DataSiswa(this.msgController);
            childForm.Show();
        }

        string Data;
        string[] splitData = new string[10];
        string[] fixData = new string[20];
        bool DataOk;

        delegate void prosesDataCallBack(string data);
        string InputData = String.Empty;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                foreach (char ch in InputData)
                {
                    if (ch =='#')
                    {
                        Data = "";
                        DataOk = true;
                    }

                    if (DataOk)
                    {
                        Data = Data + ch;
                    }

                    if (ch == '?')
                    {
                        this.BeginInvoke(new prosesDataCallBack(prosesData), new object[] { Data });                
                        DataOk = false;
                    }
                }                
            }
        }
        private void prosesData(string data)
        {
            StatusLabel.Text = data;
            this.msgController.InvokeControllerEvent(data);
        }

        private void dataSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            DialogResult dialogResult = form.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                DataSiswa childForm = new DataSiswa(this.msgController);
                childForm.Show();
            }
        }
    }
}
