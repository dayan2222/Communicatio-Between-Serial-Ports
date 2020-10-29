using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
            //string[] ports = SerialPort.GetPortNames();
            //cboPort.Items.AddRange(ports);
            //cboPort.SelectedIndex = 0;
            //btnClose.Enabled = false;
            //Thread t1 = new Thread(Print1);
            Thread t = new Thread(new ParameterizedThreadStart(loop));
            //Thread t1 = new Thread(new ThreadStart())
            t.Start();

        }
        private void loop(object obj)
        {
            string str = (string)obj;

            for (int i = 0; i < 10; i++)
            {
                // Don't do this: you can't change a control from another thread. Danger Will Robinson!
                //txtMessage.Text = i + str;
                //string v = "hello";
                //txtMessage.Text = v;
                txtMessage.Invoke((Action)delegate

                {

                    txtMessage.Text = i.ToString();

                });
                Thread.Sleep(1000);
            }
        }
        static void Print1()
        {
            Console.WriteLine("Print1() running on {0} Thread", Thread.CurrentThread.Name);
            for (int i = 1; i < 10; i++)
            {
                
                Thread.Sleep(1000);
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //btnOpen.Enabled = false;
            //btnClose.Enabled = true;

            //try
            //{
            //    serialPort1.PortName = cboPort.Text;
            //    serialPort1.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (serialPort1.IsOpen)
            //    {
            //        serialPort1.WriteLine(txtMessage.Text + Environment.NewLine);
            //        txtMessage.Clear();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //btnOpen.Enabled = true;
            //btnClose.Enabled = false;

            //try
            //{
            //    serialPort1.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (serialPort1.IsOpen)
            //    {
            //        txtReceive.Text = serialPort1.ReadExisting();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (serialPort1.IsOpen)
            //    serialPort1.Close();
        }
    }
}
