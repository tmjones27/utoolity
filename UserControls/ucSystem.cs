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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace Utoolity.UserControls
{
    public partial class ucSystem : UserControl
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public ucSystem()
        {
            InitializeComponent();

            var x = 0;
            foreach (DriveInfo d in allDrives)
            {
                lblNoDrives.Text = "Number of drives detected: " + (x + 1).ToString();
                x++;
                if (d.IsReady == true)
                {
                    lstDrives.Items.Add(string.Format("{0} ", d.Name + d.VolumeLabel));
                }
            }

            string sel = lstDrives.Text;

            if ((!String.IsNullOrEmpty(sel)))
            {
                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady == true)
                    {
                        txtOutput.Text += string.Format("Volume label: {0}, ", d.VolumeLabel);
                        txtOutput.Text += string.Format("File system: {0}, ", d.DriveFormat);
                        txtOutput.Text += string.Format("Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                        txtOutput.Text += string.Format("Total available space: {0, 15} bytes", d.TotalFreeSpace);
                        txtOutput.Text += string.Format("Total size of drive: {0, 15} bytes ", d.TotalSize);
                    }
                }
            }
        }
        public void sfcVerify(string newInput) //permission issues - revist 
        {
            string path = txtInput.Text;

            try
            {
                Process sfc = new Process();
                ProcessStartInfo info = new ProcessStartInfo
                {
                    Verb = "runas",
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    Arguments = "/K" + "sfc /VERIFYFILE=" + path,
                };
                sfc.StartInfo = info;
                sfc.Start();
                sfc.WaitForExit();
                sfc.Close();
            }
            catch
            {
                MessageBox.Show("Unable to elevate!");
                Application.Restart();
            }
        }
        public void sfcScan() // issues - revist
        {
            try
            {
                Process sfcscan = new Process();
                sfcscan.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + @"../../batch/sfcscan.bat";
                sfcscan.StartInfo.UseShellExecute = true;
                sfcscan.StartInfo.Arguments = "";
                sfcscan.StartInfo.Verb = "runas";
                sfcscan.StartInfo.CreateNoWindow = false;
                sfcscan.Start();
                sfcscan.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Unable to elevate!");
                Application.Restart();
            }
        }
        private void btnSFCVerify_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("Use Browse button to select a file!");
            }
            else
            {
                sfcVerify(txtInput.Text);
            }
        }

        private void btnSFC_Click(object sender, EventArgs e)
        {
            sfcScan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fr = new OpenFileDialog();

            fr.Title = "Open File";
            //fr.Filter = "";
            fr.InitialDirectory = @"c:\Desktop";
            fr.FilterIndex = 2;
            fr.RestoreDirectory = true;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                string path = fr.FileName;
                txtInput.Text = path;
            }
        }

        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e) //need to index
        {
            txtOutput.Text = lstDrives.SelectedItem.ToString();
            var sel = lstDrives.Text;

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true && lstDrives.Text == sel)
                {
            
                }
            }
            
        }
    }
}
