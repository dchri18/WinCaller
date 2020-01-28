using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using WinCaller.Core;

namespace WinCaller
{
    public partial class SetupForm : Form
    {
        private List<string> _numbers;

        public SetupForm()
        {
            InitializeComponent();
            Size = new Size(400, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            _numbers = new List<string>();
        }

        public SetupForm(string sid, string token)
        {
            InitializeComponent();
            Size = new Size(400, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            textBoxSID.Text = sid;
            textBoxToken.Text = token;

            _numbers = new List<string>();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = "";
            comboBoxNumbers.Enabled = false;

            // Check to see if the entry boxes have values in them
            if (textBoxSID.Text == "" || textBoxToken.Text == "")
            {
                richTextBoxOutput.Text = "Neither the SID or Token for the Twilio account has been provided.\r\n" +
                                         "If you do not have them please create a Twilio account at https://www.twilio.com to recieve them.";
                return;
            }

            // Make sure the TwilioClient initialisation and number retrieval is successful        
            try
            {
                TwilioClient.Init(textBoxSID.Text, textBoxToken.Text);
                var list = IncomingPhoneNumberResource.Read();

                // Now show the retrieved numbers          
                _numbers.Clear();
                comboBoxNumbers.Items.Clear();
                foreach (var number in list)
                {
                    _numbers.Add(number.PhoneNumber.ToString());
                    comboBoxNumbers.Items.Add(number.PhoneNumber.ToString());
                }
                comboBoxNumbers.Enabled = true;
            }
            catch (Exception ex)
            {
                richTextBoxOutput.Text = $"A {ex.GetType()} has been thrown with the message:\r\n{ex.Message}";
            }
        }

        private void buttonFinished_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = "";

            if (textBoxSID.Text == "" || textBoxToken.Text == "" || comboBoxNumbers.SelectedItem == null)
            {
                richTextBoxOutput.Text = "All required information has not been provided. Please input a valid SID, Token and Phone Number.";
                return;
            }

            // Initialise Settings through the WinCaller.Core.Controller
            try
            {
                Controller.CreateNewSettings(textBoxSID.Text, textBoxToken.Text, _numbers, comboBoxNumbers.SelectedItem.ToString());
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                richTextBoxOutput.Text = $"A {ex.GetType()} has been thrown with the message:\r\n{ex.Message} and the program cannot continue.";
            }
        }
    }
}
