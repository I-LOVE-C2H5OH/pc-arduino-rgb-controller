using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedTrialApp
{
    public partial class Form1 : Form
    {

        SerialPort serialPort1;

        public Form1()
        {
            
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            SystemEvents.PowerModeChanged += OnPowerChange;
            AnimationCombo.SelectedIndex = 0;
            serialPort1 = new SerialPort("COM" +comport.Text, 38400);
            myNotifyIcon.Visible = true;

            //Smart notifications
            // Send a UDP Packet to PC with the format LEDX10:R,G,B,254
            // R,G,B values between 0-255
            // 254 <-- notification effect
            Task.Run(() =>
            {
                using (var udpClient = new UdpClient(55050))
                {
                    string loggingEvent = "";
                    while (true)
                    {
                        //IPEndPoint object will allow us to read datagrams sent from any source.
                        var remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                        var receivedResults = udpClient.Receive(ref remoteEndPoint);
                        loggingEvent += Encoding.ASCII.GetString(receivedResults);
                        //Console.WriteLine(loggingEvent);
                        //label1.Text = Encoding.ASCII.GetString(receivedResults);
                        if (receivedResults.Length > 1)
                        {
                            string[] res = Encoding.ASCII.GetString(receivedResults).Split(':');
                            if (res[0].Equals("LEDX10")) { 
                                setColor(res[1]);
                                this.Invoke((MethodInvoker)delegate {
                                    setGUIColor(Properties.Settings.Default.CurrentColor);
                                });
                               
                            }
                        }
                    }
                }
            });
            setColor(Properties.Settings.Default.CurrentColor);
            setGUIColor(Properties.Settings.Default.CurrentColor);
            

        }

        //Action on PC Power state change
        private void OnPowerChange(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    setColor("0,0,0,255");
                    break;
                case PowerModes.Resume:
                    //setColor(Properties.Settings.Default.CurrentColor);
                    break;
            }

        }
        //Action on PC Power state change
        private void OnProcessExit(object sender, EventArgs e)
        {
            setColor("0,0,0,255");
        }

        private void setGUIColor(string color)
        {
            string[] colors = Properties.Settings.Default.CurrentColor.Split(',');
            redlbl.Text = colors[0];
            greenlbl.Text = colors[1];
            bluelbl.Text = colors[2];
            int val;
            Int32.TryParse(colors[0], out val );
            redSlider.Value = val;
            Int32.TryParse(colors[1], out val);
            greenSlider.Value = val;
            Int32.TryParse(colors[2], out val);
            blueSlider.Value = val;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            string color = "255,255,255";

            switch (s)
            {
                case "Red":
                    color = "255,0,0,0";
                    break;
                case "Green":
                    color = "0,255,0,0";
                    break;
                case "Blue":
                    color = "0,0,255,0";
                    break;
                case "Rainbow":
                    color = "0,0,0,2";
                    break;
                case "White":
                    color = "255,255,255,0";
                    break;
            }
            setColor(color);
            //serialPort1.NewLine = "\n";
           // color= color + "\n\n";
            
        }

        private void setColor(string color)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    Console.WriteLine("PORT IS OPEN:");
                    serialPort1.Open();


                    //byte[] b = BitConverter.GetBytes(color);
                    //serialPort1.Write(color);
                    //byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(color);
                    //byte[] MyMessage = System.Text.Encoding.GetEncoding(1252).GetBytes(color);
                    // serialPort1.Write(MyMessage, 0, MyMessage.Length);
                    serialPort1.WriteLine(color);
                    serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }
        }
        private void setColor(string color, int animation)
        {
            setColor(color + "," + animation);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentColor = redSlider.Value + "," + greenSlider.Value + "," + blueSlider.Value + "," + AnimationCombo.SelectedIndex;
            setColor(redSlider.Value+","+greenSlider.Value+ ","+blueSlider.Value, AnimationCombo.SelectedIndex);
        }

        private void redSlider_ValueChanged(object sender, EventArgs e)
        {
            redlbl.Text = redSlider.Value+"";
            rgbBox.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void greenSlider_ValueChanged(object sender, EventArgs e)
        {
            greenlbl.Text = greenSlider.Value + "";
            rgbBox.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void blueSlider_ValueChanged(object sender, EventArgs e)
        {
            bluelbl.Text = blueSlider.Value + "";
            rgbBox.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void comport_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1 = new SerialPort("COM"+comport.Text, 38400);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //setColor("0,0,0,0");
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            
                setColor("0,0,0,255");

        }

        

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void myNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setColor("0,0,0,255");
            Application.Exit();
        }


    }
}
