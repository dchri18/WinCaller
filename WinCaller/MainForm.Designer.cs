namespace WinCaller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLinks = new System.Windows.Forms.Panel();
            this.pictureBoxTwilio = new System.Windows.Forms.PictureBox();
            this.pictureBoxGitHub = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinkedIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxSMS = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoneBook = new System.Windows.Forms.PictureBox();
            this.pictureBoxCall = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLinks
            // 
            this.panelLinks.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLinks.Controls.Add(this.pictureBoxTwilio);
            this.panelLinks.Controls.Add(this.pictureBoxGitHub);
            this.panelLinks.Controls.Add(this.pictureBoxLinkedIn);
            this.panelLinks.Location = new System.Drawing.Point(86, 312);
            this.panelLinks.Name = "panelLinks";
            this.panelLinks.Size = new System.Drawing.Size(218, 68);
            this.panelLinks.TabIndex = 0;
            // 
            // pictureBoxTwilio
            // 
            this.pictureBoxTwilio.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTwilio.BackgroundImage = global::WinCaller.Properties.Resources.twilio_mark_red_fcbdfe874;
            this.pictureBoxTwilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTwilio.Location = new System.Drawing.Point(13, 3);
            this.pictureBoxTwilio.Name = "pictureBoxTwilio";
            this.pictureBoxTwilio.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxTwilio.TabIndex = 7;
            this.pictureBoxTwilio.TabStop = false;
            this.pictureBoxTwilio.Click += new System.EventHandler(this.pictureBoxTwilio_Click);
            // 
            // pictureBoxGitHub
            // 
            this.pictureBoxGitHub.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGitHub.BackgroundImage = global::WinCaller.Properties.Resources.icons8_github_480;
            this.pictureBoxGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGitHub.Location = new System.Drawing.Point(145, 3);
            this.pictureBoxGitHub.Name = "pictureBoxGitHub";
            this.pictureBoxGitHub.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxGitHub.TabIndex = 6;
            this.pictureBoxGitHub.TabStop = false;
            this.pictureBoxGitHub.Click += new System.EventHandler(this.pictureBoxGitHub_Click);
            // 
            // pictureBoxLinkedIn
            // 
            this.pictureBoxLinkedIn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLinkedIn.BackgroundImage = global::WinCaller.Properties.Resources.icons8_linkedin_480;
            this.pictureBoxLinkedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLinkedIn.Location = new System.Drawing.Point(79, 3);
            this.pictureBoxLinkedIn.Name = "pictureBoxLinkedIn";
            this.pictureBoxLinkedIn.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLinkedIn.TabIndex = 5;
            this.pictureBoxLinkedIn.TabStop = false;
            this.pictureBoxLinkedIn.Click += new System.EventHandler(this.pictureBoxLinkedIn_Click);
            // 
            // pictureBoxSMS
            // 
            this.pictureBoxSMS.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSMS.BackgroundImage = global::WinCaller.Properties.Resources.icons8_sms_100;
            this.pictureBoxSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSMS.Location = new System.Drawing.Point(123, 156);
            this.pictureBoxSMS.Name = "pictureBoxSMS";
            this.pictureBoxSMS.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSMS.TabIndex = 2;
            this.pictureBoxSMS.TabStop = false;
            // 
            // pictureBoxPhoneBook
            // 
            this.pictureBoxPhoneBook.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoneBook.BackgroundImage = global::WinCaller.Properties.Resources.icons8_address_book_100;
            this.pictureBoxPhoneBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoneBook.Location = new System.Drawing.Point(169, 156);
            this.pictureBoxPhoneBook.Name = "pictureBoxPhoneBook";
            this.pictureBoxPhoneBook.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPhoneBook.TabIndex = 3;
            this.pictureBoxPhoneBook.TabStop = false;
            // 
            // pictureBoxCall
            // 
            this.pictureBoxCall.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCall.BackgroundImage")));
            this.pictureBoxCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCall.Location = new System.Drawing.Point(142, 29);
            this.pictureBoxCall.Name = "pictureBoxCall";
            this.pictureBoxCall.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCall.TabIndex = 1;
            this.pictureBoxCall.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.BackgroundImage = global::WinCaller.Properties.Resources.icons8_settings_100;
            this.pictureBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSettings.Location = new System.Drawing.Point(215, 156);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSettings.TabIndex = 4;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created by Daniel Christensen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Link to GitHub above";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPhoneBook);
            this.Controls.Add(this.pictureBoxCall);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.panelLinks);
            this.Controls.Add(this.pictureBoxSMS);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.panelLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLinks;
        private System.Windows.Forms.PictureBox pictureBoxTwilio;
        private System.Windows.Forms.PictureBox pictureBoxGitHub;
        private System.Windows.Forms.PictureBox pictureBoxLinkedIn;
        private System.Windows.Forms.PictureBox pictureBoxSMS;
        private System.Windows.Forms.PictureBox pictureBoxPhoneBook;
        private System.Windows.Forms.PictureBox pictureBoxCall;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}