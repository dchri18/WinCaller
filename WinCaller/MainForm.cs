using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCaller.Core;

namespace WinCaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Size = new Size(400, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.FromArgb(46, 204, 114), 2);
            l.DrawEllipse(p, 130, 20, 120, 120);
            l.Dispose();
        }

        private void pictureBoxTwilio_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.twilio.com/");
            Process.Start(sInfo);
        }

        private void pictureBoxLinkedIn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.linkedin.com/in/daniel-christensen-21652b1a0/");
            Process.Start(sInfo);
        }

        private void pictureBoxGitHub_Click(object sender, EventArgs e)
        {
        
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/dchri18");
            Process.Start(sInfo);
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            var form = new SetupForm(Controller.Settings.AccountSid, Controller.Settings.AuthToken);
            form.ShowDialog(this);
        }
    }
}
