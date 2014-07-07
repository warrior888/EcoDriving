using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using ObdLibSharp;
namespace obdLibWrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ObdThread obdThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            obdThread = new ObdThread();
            obdThread.pidReply += new ObdThread.pidReplyDelegate(obdThread_pidReply);
            
        }
        void obdThread_pidReplyInvoked(string mode, string val, int set, double time)
        {
            /*textBox1.Text += mode + ":" + val + "\r\n";
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();*/
            for (int i = 0; i < pidListView.Items.Count; i++)
            {
                if (pidListView.Items[i].Text == mode)
                {
                    pidListView.Items[i].SubItems[1].Text = val;
                }
            }
        }
        void obdThread_pidReply(string mode, string val, int set, double time)
        {
            this.Invoke(new ObdThread.pidReplyDelegate(obdThread_pidReplyInvoked), new object[] { mode, val, set, time });
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            obdThread.setPort(portTextBox.Text);
            obdThread.setBaud(int.Parse(baudTextBox.Text));
            obdThread.connect();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            obdThread.disconnect();
        }

        private void addPidbutton_Click(object sender, EventArgs e)
        {
            /*obdThread.addModePidReq("01", "0C");
            obdThread.addModePidReq("01", "0D");
            obdThread.addModePidReq("01", "04");*/
            if (pidTextBox.Text.Length != 4)
            {
                MessageBox.Show("Error! PID To be added is not valid!. Must be in form ModePid as: 010C for Mode 0x01 Pid 0x0C");
                return;
            }
            pidListView.Items.Add(pidTextBox.Text);
            pidListView.Items[pidListView.Items.Count - 1].SubItems.Add("0");
            obdThread.addModePidReq(pidTextBox.Text.Substring(0, 2), pidTextBox.Text.Substring(2, 2));
        }

        private void removePidButton_Click(object sender, EventArgs e)
        {
            if (pidListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No pids selected!");
                return;
            }
            for (int i = 0; i < pidListView.SelectedItems.Count; i++)
            {
                obdThread.delModePidReq(pidListView.SelectedItems[i].Text.Substring(0, 2), pidListView.SelectedItems[i].Text.Substring(2, 2));
                pidListView.Items.Remove(pidListView.SelectedItems[i]);
                i--;
            }
        }
    }
}
