namespace HRM_SUB
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewNotification = new System.Windows.Forms.TabPage();
            this.panelApplication = new System.Windows.Forms.Panel();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromdate = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmployeeName2 = new System.Windows.Forms.Label();
            this.labelAppId = new System.Windows.Forms.Label();
            this.labelApplicationFor = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.sendNotification = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textAppNo = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textLeaveLoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.viewNotification.SuspendLayout();
            this.panelApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.sendNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.viewNotification);
            this.tabControl1.Controls.Add(this.sendNotification);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // viewNotification
            // 
            this.viewNotification.BackColor = System.Drawing.Color.Transparent;
            this.viewNotification.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.viewNotification.Controls.Add(this.panelApplication);
            this.viewNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewNotification.Location = new System.Drawing.Point(4, 29);
            this.viewNotification.Margin = new System.Windows.Forms.Padding(5);
            this.viewNotification.Name = "viewNotification";
            this.viewNotification.Padding = new System.Windows.Forms.Padding(5);
            this.viewNotification.Size = new System.Drawing.Size(1100, 597);
            this.viewNotification.TabIndex = 0;
            this.viewNotification.Text = "View Application";
            // 
            // panelApplication
            // 
            this.panelApplication.Controls.Add(this.labelToDate);
            this.panelApplication.Controls.Add(this.labelFromdate);
            this.panelApplication.Controls.Add(this.labelId);
            this.panelApplication.Controls.Add(this.labelEmployeeName2);
            this.panelApplication.Controls.Add(this.labelAppId);
            this.panelApplication.Controls.Add(this.labelApplicationFor);
            this.panelApplication.Controls.Add(this.labelStatus);
            this.panelApplication.Controls.Add(this.label9);
            this.panelApplication.Controls.Add(this.labelContact);
            this.panelApplication.Controls.Add(this.label19);
            this.panelApplication.Controls.Add(this.pictureBoxUser);
            this.panelApplication.Controls.Add(this.labelLocation);
            this.panelApplication.Controls.Add(this.label12);
            this.panelApplication.Controls.Add(this.labelType);
            this.panelApplication.Controls.Add(this.label10);
            this.panelApplication.Controls.Add(this.label16);
            this.panelApplication.Controls.Add(this.label17);
            this.panelApplication.Controls.Add(this.button5);
            this.panelApplication.Controls.Add(this.button4);
            this.panelApplication.Controls.Add(this.button3);
            this.panelApplication.Controls.Add(this.labelApplicationDate);
            this.panelApplication.Location = new System.Drawing.Point(23, 37);
            this.panelApplication.Name = "panelApplication";
            this.panelApplication.Size = new System.Drawing.Size(1053, 337);
            this.panelApplication.TabIndex = 11;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(207, 119);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(86, 20);
            this.labelToDate.TabIndex = 41;
            this.labelToDate.Text = "To Date     ";
            // 
            // labelFromdate
            // 
            this.labelFromdate.AutoSize = true;
            this.labelFromdate.Location = new System.Drawing.Point(207, 85);
            this.labelFromdate.Name = "labelFromdate";
            this.labelFromdate.Size = new System.Drawing.Size(89, 20);
            this.labelFromdate.TabIndex = 40;
            this.labelFromdate.Text = "From Date ";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(801, 227);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(97, 20);
            this.labelId.TabIndex = 39;
            this.labelId.Text = "Employee Id";
            // 
            // labelEmployeeName2
            // 
            this.labelEmployeeName2.AutoSize = true;
            this.labelEmployeeName2.Location = new System.Drawing.Point(801, 247);
            this.labelEmployeeName2.Name = "labelEmployeeName2";
            this.labelEmployeeName2.Size = new System.Drawing.Size(123, 20);
            this.labelEmployeeName2.TabIndex = 39;
            this.labelEmployeeName2.Text = "Employee name";
            // 
            // labelAppId
            // 
            this.labelAppId.AutoSize = true;
            this.labelAppId.Location = new System.Drawing.Point(798, 87);
            this.labelAppId.Name = "labelAppId";
            this.labelAppId.Size = new System.Drawing.Size(105, 20);
            this.labelAppId.TabIndex = 38;
            this.labelAppId.Text = "Application Id";
            // 
            // labelApplicationFor
            // 
            this.labelApplicationFor.AutoSize = true;
            this.labelApplicationFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationFor.Location = new System.Drawing.Point(333, 0);
            this.labelApplicationFor.Name = "labelApplicationFor";
            this.labelApplicationFor.Size = new System.Drawing.Size(337, 31);
            this.labelApplicationFor.TabIndex = 12;
            this.labelApplicationFor.Text = "Leave Application Request";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(207, 252);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(138, 20);
            this.labelStatus.TabIndex = 37;
            this.labelStatus.Text = "Application Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Application Status";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(207, 220);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(127, 20);
            this.labelContact.TabIndex = 37;
            this.labelContact.Text = "Contact Addition";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Contact Addition";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(796, 126);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(102, 93);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 36;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(207, 187);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(121, 20);
            this.labelLocation.TabIndex = 35;
            this.labelLocation.Text = "Leave Location ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Leave Location ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(206, 153);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(90, 20);
            this.labelType.TabIndex = 34;
            this.labelType.Text = "Leave Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Leave Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "To Date     ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "From Date ";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(240, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 36);
            this.button5.TabIndex = 28;
            this.button5.Text = "Modifi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(132, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 36);
            this.button4.TabIndex = 28;
            this.button4.Text = "Reject";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(29, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 36);
            this.button3.TabIndex = 28;
            this.button3.Text = "Accept";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Location = new System.Drawing.Point(798, 64);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(126, 20);
            this.labelApplicationDate.TabIndex = 27;
            this.labelApplicationDate.Text = "Application Date";
            // 
            // sendNotification
            // 
            this.sendNotification.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.sendNotification.Controls.Add(this.comboBox1);
            this.sendNotification.Controls.Add(this.textBox1);
            this.sendNotification.Controls.Add(this.label8);
            this.sendNotification.Controls.Add(this.textAppNo);
            this.sendNotification.Controls.Add(this.textContact);
            this.sendNotification.Controls.Add(this.textLeaveLoc);
            this.sendNotification.Controls.Add(this.label7);
            this.sendNotification.Controls.Add(this.label6);
            this.sendNotification.Controls.Add(this.label5);
            this.sendNotification.Controls.Add(this.dateTimeTo);
            this.sendNotification.Controls.Add(this.label4);
            this.sendNotification.Controls.Add(this.label3);
            this.sendNotification.Controls.Add(this.dateTimeFrom);
            this.sendNotification.Controls.Add(this.label2);
            this.sendNotification.Controls.Add(this.label1);
            this.sendNotification.Controls.Add(this.button2);
            this.sendNotification.Controls.Add(this.button1);
            this.sendNotification.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.sendNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendNotification.Location = new System.Drawing.Point(4, 29);
            this.sendNotification.Margin = new System.Windows.Forms.Padding(5);
            this.sendNotification.Name = "sendNotification";
            this.sendNotification.Padding = new System.Windows.Forms.Padding(5);
            this.sendNotification.Size = new System.Drawing.Size(1100, 597);
            this.sendNotification.TabIndex = 1;
            this.sendNotification.Text = "Send Application";
            this.sendNotification.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASUAL LEAVE",
            "MEDICAL LEAVE",
            "MAINTENANCE LEAVE",
            "EARNED LEAVE"});
            this.comboBox1.Location = new System.Drawing.Point(369, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(369, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 26);
            this.textBox1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Application Date";
            // 
            // textAppNo
            // 
            this.textAppNo.Enabled = false;
            this.textAppNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAppNo.Location = new System.Drawing.Point(369, 113);
            this.textAppNo.Name = "textAppNo";
            this.textAppNo.Size = new System.Drawing.Size(307, 26);
            this.textAppNo.TabIndex = 25;
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(369, 396);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(307, 26);
            this.textContact.TabIndex = 22;
            // 
            // textLeaveLoc
            // 
            this.textLeaveLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLeaveLoc.Location = new System.Drawing.Point(369, 347);
            this.textLeaveLoc.Name = "textLeaveLoc";
            this.textLeaveLoc.Size = new System.Drawing.Size(307, 26);
            this.textLeaveLoc.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Contact Addition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Leave Location ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Leave Type";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Location = new System.Drawing.Point(369, 246);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(307, 26);
            this.dateTimeTo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "To Date     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "From Date ";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Location = new System.Drawing.Point(369, 195);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(307, 26);
            this.dateTimeFrom.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Leave Application Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Application No ";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(334, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(218, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Application";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.tabControl1.ResumeLayout(false);
            this.viewNotification.ResumeLayout(false);
            this.panelApplication.ResumeLayout(false);
            this.panelApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.sendNotification.ResumeLayout(false);
            this.sendNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage viewNotification;
        private System.Windows.Forms.TabPage sendNotification;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLeaveLoc;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textAppNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelApplication;
        private System.Windows.Forms.Label labelApplicationDate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelApplicationFor;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEmployeeName2;
        private System.Windows.Forms.Label labelAppId;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromdate;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label9;
    }
}