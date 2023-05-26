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
using System.Net.Sockets;
using System.Net;


namespace Utoolity.UserControls
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            GetCompName();
            txtIPAddr.Text = GetLocalIPAddr();
            GetNameOS();
            GetRAM();
        }
        public void GetCompName() 
        {
            string pcName = Environment.MachineName;
            txtPCName.Text = pcName;
        }
        public static string GetLocalIPAddr()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                    
                }
            }
            throw new Exception("No IPv4 network adapters found in system!");
        }
        public void GetNameOS()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();

            bool is64bit = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));

            if (name == null && is64bit == true)
            {
                name = "unknown";
                txtNameOS.Text = name.ToString() + " x64";
            }
            if (name == null && is64bit == false)
            {
                name = "unknown";
                txtNameOS.Text = name.ToString() + " x86";
            }
            if (name != null && is64bit == true)
            {
                txtNameOS.Text = name.ToString() + " x64";
            }
            if (name != null && is64bit == false)
            {
                txtNameOS.Text = name.ToString() + " x86";
            }
        }
        public void GetRAM()
        {
            ObjectQuery wmi_obj = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher _findObj = new ManagementObjectSearcher(wmi_obj);
            ManagementObjectCollection _ramInfo = _findObj.Get();

            foreach (ManagementObject _ram in _ramInfo)
            {
                var v = Convert.ToDouble(_ram["TotalVisibleMemorySize"]);
                var y = v / (1024 * 1024);
                txtRAM.Text = string.Format("{0:0.00}", y) + " GB"; //look into determining GBs
            }
        }
    }
}
