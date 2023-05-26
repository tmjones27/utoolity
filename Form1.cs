using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utoolity.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

/* BIS415 - IT Capstone in Programming and Desktop Applications
 * Program designed and created by Tiani Jones, icons are courtesy of Freepik
 * Copyright © 2023 Captone Project. All rights reserved.
 */

namespace Utoolity
{
    public partial class Utoolity : Form
    {
        public Utoolity()
        {
            InitializeComponent();
            ucHome uc = new ucHome();
            switchView(uc);
        }
        private void switchView(UserControl newView)
        {
            newView.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(newView);
            newView.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "Utoolity";
            ucHome uc = new ucHome();
            switchView(uc);
        }

        private void btnNetUtils_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "Networking";
            ucNetwork uc = new ucNetwork();
            switchView(uc);
        }

        private void btnSysUtils_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "System Tools";
            ucSystem uc = new ucSystem();
            switchView(uc);

        }

        private void btnSecUtils_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "Security Settings";
            ucSecurity uc = new ucSecurity();
            switchView(uc);
        }

        private void btnICS_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "Wireless Sharing";
            ucICS uc = new ucICS();
            switchView(uc);
        }

        private void btnUpdateUtils_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "Update Utilites";
            ucUpdater uc = new ucUpdater();
            switchView(uc);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            lblBlank.Text = "About Utoolity";
            ucAboutUs uc = new ucAboutUs();
            switchView(uc);
        }
    }
        
}
