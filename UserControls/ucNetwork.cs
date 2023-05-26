using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.IO;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;

namespace Utoolity.UserControls
{
    public partial class ucNetwork : UserControl
    {
        public ucNetwork()
        {
            InitializeComponent(); 
            txtBlank.Enabled = false;
        }
        private void ProgressBar()
        {
            progressBar1.Visible = Enabled;
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 1;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;

            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; progressBar1.Step++)
            {
                progressBar1.Value = i;
            }
        }

        private bool isProcessRunning = false;
        
        public void ProgressFunct() //currently not used, need to intergrate - copy to other parts of code
        {
            if (isProcessRunning)
            {
                MessageBox.Show("A process is already running.");
                return;
            }

            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    isProcessRunning = true;

                    for (int n = 0; n < 100; n++)
                    {
                        Thread.Sleep(50);
                        progressBar1.BeginInvoke(
                            new Action(() =>
                            {
                                progressBar1.Value = n;
                            }
                        ));
                    }
                    MessageBox.Show("Thread completed!");
                    progressBar1.BeginInvoke(
                            new Action(() =>
                            {
                                progressBar1.Value = 0;
                            }
                    ));

                    isProcessRunning = false;
                }
            ));
            backgroundThread.Start();
        }
        public void cmdCommands(string newCommand, TextBox newTextbox) 
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = newCommand;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            StreamReader reader = cmdProcess.StandardOutput;
            newTextbox.Text = reader.ReadToEnd();
            cmdProcess.WaitForExit(1000 * 60 * 1);
            cmdProcess.Close();
        }
        public void cmdCommandsArg(string newCommand, string newArgument, TextBox newTextbox)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = newCommand;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.StartInfo.Arguments = newArgument;
            cmdProcess.Start();
            StreamReader reader = cmdProcess.StandardOutput;
            newTextbox.Text = reader.ReadToEnd();
            cmdProcess.WaitForExit(1000 * 60 * 1);
            cmdProcess.Close(); 
        }
        public void cmdCmnd1() //ipconfig
        {
            string c = "ipconfig";
            TextBox t = txtOutput; 
            cmdCommands(c, t);
        }
        public void cmdCmnd2() //ipconfig -all
        {
            string c = "ipconfig";
            string a = "/all";
            TextBox t = txtOutput;
            cmdCommandsArg(c, a, t);
        }
        public void cmdCmnd3() //ping -ip
        {
            if (string.IsNullOrWhiteSpace(txtBlank.Text) || txtBlank.Text == "")
            {
                MessageBox.Show("Please enter a valid IP or web address!");
            }
            else
            {
                string c = "ping";
                string a = txtBlank.Text;
                TextBox t = txtOutput;
                cmdCommandsArg(c, a, t);
            }
        }
        public void cmdCmnd4() //tracert -ip
        {
            if (string.IsNullOrWhiteSpace(txtBlank.Text) || txtBlank.Text == "")
            {
                MessageBox.Show("Please enter a valid IP or web address!");
            }
            else
            {
                string c = "tracert";
                string a = txtBlank.Text;
                TextBox t = txtOutput;
                cmdCommandsArg(c, a, t);
            }
        }
        public void cmdCmnd5() //arp -a -ip
        {       
            if (txtBlank.Text == "")
            {
                string c = "arp";
                string a = "/a";
                TextBox t = txtOutput;
                cmdCommandsArg(c, a, t);
            }
            else if (txtBlank.Text != "")
            {
                string c = "arp";
                string a = "-a " + txtBlank.Text;
                TextBox t = txtOutput;
                cmdCommandsArg(c, a, t);
            }  
        }
        public void cmdCmnd6() //nslookup
        {
            if (string.IsNullOrWhiteSpace(txtBlank.Text) || txtBlank.Text == "")
            {
                MessageBox.Show("Please enter a valid IP or web address!");
            }
            else
            {
                string c = "nslookup";
                string a = txtBlank.Text;
                TextBox t = txtOutput;
                cmdCommandsArg(c, a, t);
            }
        }
        //buttons
        private void rdoPing_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "Ping";
            txtOutput.Clear();
            chkAll.Checked = false;
            chkAll.Enabled = false;
            txtBlank.Enabled = true;
        }
        private void rdoIPConfig_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "IPConfig";
            txtBlank.Enabled = false;
            chkAll.Enabled = true;
        }
        private void rdoTracert_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "Tracert";
            txtOutput.Clear();
            txtBlank.Enabled = false;
            chkAll.Checked = false;
            chkAll.Enabled = false;
            txtBlank.Enabled = true;
        }
        private void rdoARP_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "ARP";
            txtOutput.Clear();
            txtBlank.Enabled = false;
            chkAll.Checked = false;
            chkAll.Enabled = false;
            txtBlank.Enabled = true;
        }
        private void rdoNameServ_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "NSLookUp";
            txtOutput.Clear();
            txtBlank.Enabled = Enabled;
            chkAll.Checked = false;
            chkAll.Enabled = false;
            txtBlank.Enabled = true;
        }
        private void rdoNetStat_CheckedChanged(object sender, EventArgs e)
        {
            btnBlank.Text = "NetStat";
            txtOutput.Clear();
            txtBlank.Enabled = Enabled;
            chkAll.Checked = false;
            chkAll.Enabled = false;
            txtBlank.Enabled = true;
        }
        private void btnBlank_Click(object sender, EventArgs e)
        {
            if (rdoIPConfig.Checked)
            {
                cmdCmnd1();
            }
            if (rdoIPConfig.Checked && chkAll.Checked)
            {
                cmdCmnd2();
            }
            if (rdoPing.Checked)
            {
                cmdCmnd3();
            }
            if (rdoTracert.Checked)
            {
                cmdCmnd4();
            }
            if (rdoARP.Checked)
            {
                cmdCmnd5();
            }
            if (rdoNameServ.Checked)
            {
                cmdCmnd6();
            }
            if (rdoNetStat.Checked)
            {
                //write cooresponding method
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBlank.Clear();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream;
                SaveFileDialog fs = new SaveFileDialog();
                fs.Filter = "txt files" + " (*.txt)|*.txt";
                fs.FilterIndex = 2;
                fs.RestoreDirectory = true;
                if (fs.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = fs.OpenFile()) != null)
                    {
                        using (StreamWriter writeToFile = new StreamWriter(myStream))
                        {
                            writeToFile.Write(DateTime.Now.ToString("MM/dd/yyyy " + " hh:mm:ss"), Environment.NewLine);
                            writeToFile.Write("\n" + txtOutput.Text);
                        }
                        myStream.Close();
                        MessageBox.Show("File saved!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry. Specific file path is invalid. Please try again!");
            }
        }
        private void btnForceQ_Click(object sender, EventArgs e)
        {
            //write block of code
        }

        
    }
}
