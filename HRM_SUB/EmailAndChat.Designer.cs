namespace HRM_SUB
{
    partial class EmailAndChat
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureSecendUser = new System.Windows.Forms.PictureBox();
            this.comboBoxEditId = new System.Windows.Forms.ComboBox();
            this.employeeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMR_DBDataSet = new HRM_SUB.HMR_DBDataSet();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUserName2 = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureCurrentUser = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textCurrentUserName = new System.Windows.Forms.TextBox();
            this.textCurrentUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.tabPageSendChat = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFriendPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFriendIp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.employee_infoTableAdapter = new HRM_SUB.HMR_DBDataSetTableAdapters.Employee_infoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageEmail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecendUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrentUser)).BeginInit();
            this.tabPageSendChat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmail);
            this.tabControl1.Controls.Add(this.tabPageSendChat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 741);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.tabPageEmail.Controls.Add(this.label9);
            this.tabPageEmail.Controls.Add(this.labelFileName);
            this.tabPageEmail.Controls.Add(this.button1);
            this.tabPageEmail.Controls.Add(this.label7);
            this.tabPageEmail.Controls.Add(this.groupBox4);
            this.tabPageEmail.Controls.Add(this.groupBox3);
            this.tabPageEmail.Controls.Add(this.buttonSendEmail);
            this.tabPageEmail.Controls.Add(this.label8);
            this.tabPageEmail.Controls.Add(this.textBoxSubject);
            this.tabPageEmail.Controls.Add(this.richTextBoxBody);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmail.Size = new System.Drawing.Size(1051, 708);
            this.tabPageEmail.TabIndex = 0;
            this.tabPageEmail.Text = "Email";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(396, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Send email";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(129, 125);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 20);
            this.labelFileName.TabIndex = 9;
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Message";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureSecendUser);
            this.groupBox4.Controls.Add(this.comboBoxEditId);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxUserName2);
            this.groupBox4.Controls.Add(this.textBoxUserEmail2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(622, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 219);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reciver";
            // 
            // pictureSecendUser
            // 
            this.pictureSecendUser.Location = new System.Drawing.Point(19, 27);
            this.pictureSecendUser.Name = "pictureSecendUser";
            this.pictureSecendUser.Size = new System.Drawing.Size(75, 71);
            this.pictureSecendUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSecendUser.TabIndex = 5;
            this.pictureSecendUser.TabStop = false;
            // 
            // comboBoxEditId
            // 
            this.comboBoxEditId.DataSource = this.employeeinfoBindingSource;
            this.comboBoxEditId.DisplayMember = "Employee_ID";
            this.comboBoxEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditId.FormattingEnabled = true;
            this.comboBoxEditId.Location = new System.Drawing.Point(110, 107);
            this.comboBoxEditId.Name = "comboBoxEditId";
            this.comboBoxEditId.Size = new System.Drawing.Size(274, 28);
            this.comboBoxEditId.TabIndex = 29;
            this.comboBoxEditId.ValueMember = "Employee_ID";
            this.comboBoxEditId.SelectedIndexChanged += new System.EventHandler(this.editOnChange);
            // 
            // employeeinfoBindingSource
            // 
            this.employeeinfoBindingSource.DataMember = "Employee_info";
            this.employeeinfoBindingSource.DataSource = this.hMR_DBDataSet;
            // 
            // hMR_DBDataSet
            // 
            this.hMR_DBDataSet.DataSetName = "HMR_DBDataSet";
            this.hMR_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "User Name";
            // 
            // textBoxUserName2
            // 
            this.textBoxUserName2.Location = new System.Drawing.Point(110, 145);
            this.textBoxUserName2.Name = "textBoxUserName2";
            this.textBoxUserName2.Size = new System.Drawing.Size(274, 26);
            this.textBoxUserName2.TabIndex = 1;
            // 
            // textBoxUserEmail2
            // 
            this.textBoxUserEmail2.Location = new System.Drawing.Point(110, 183);
            this.textBoxUserEmail2.Name = "textBoxUserEmail2";
            this.textBoxUserEmail2.Size = new System.Drawing.Size(274, 26);
            this.textBoxUserEmail2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureCurrentUser);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textCurrentUserName);
            this.groupBox3.Controls.Add(this.textCurrentUserEmail);
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(615, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 222);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "You";
            // 
            // pictureCurrentUser
            // 
            this.pictureCurrentUser.Location = new System.Drawing.Point(19, 31);
            this.pictureCurrentUser.Name = "pictureCurrentUser";
            this.pictureCurrentUser.Size = new System.Drawing.Size(75, 71);
            this.pictureCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCurrentUser.TabIndex = 6;
            this.pictureCurrentUser.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Paassword";
            // 
            // textCurrentUserName
            // 
            this.textCurrentUserName.Enabled = false;
            this.textCurrentUserName.Location = new System.Drawing.Point(116, 109);
            this.textCurrentUserName.Name = "textCurrentUserName";
            this.textCurrentUserName.Size = new System.Drawing.Size(274, 26);
            this.textCurrentUserName.TabIndex = 1;
            // 
            // textCurrentUserEmail
            // 
            this.textCurrentUserEmail.Enabled = false;
            this.textCurrentUserEmail.Location = new System.Drawing.Point(115, 146);
            this.textCurrentUserEmail.Name = "textCurrentUserEmail";
            this.textCurrentUserEmail.Size = new System.Drawing.Size(274, 26);
            this.textCurrentUserEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(116, 181);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "User Name";
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.Location = new System.Drawing.Point(623, 548);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(103, 41);
            this.buttonSendEmail.TabIndex = 4;
            this.buttonSendEmail.Text = "Send";
            this.buttonSendEmail.UseVisualStyleBackColor = true;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(8, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 71);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(588, 26);
            this.textBoxSubject.TabIndex = 1;
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Location = new System.Drawing.Point(12, 189);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(588, 400);
            this.richTextBoxBody.TabIndex = 0;
            this.richTextBoxBody.Text = "";
            // 
            // tabPageSendChat
            // 
            this.tabPageSendChat.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.tabPageSendChat.Controls.Add(this.label14);
            this.tabPageSendChat.Controls.Add(this.listBox1);
            this.tabPageSendChat.Controls.Add(this.buttonStart);
            this.tabPageSendChat.Controls.Add(this.buttonSend);
            this.tabPageSendChat.Controls.Add(this.listMessage);
            this.tabPageSendChat.Controls.Add(this.textMessage);
            this.tabPageSendChat.Controls.Add(this.groupBox2);
            this.tabPageSendChat.Controls.Add(this.groupBox1);
            this.tabPageSendChat.Location = new System.Drawing.Point(4, 29);
            this.tabPageSendChat.Name = "tabPageSendChat";
            this.tabPageSendChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSendChat.Size = new System.Drawing.Size(1051, 708);
            this.tabPageSendChat.TabIndex = 1;
            this.tabPageSendChat.Text = "Chat";
            this.tabPageSendChat.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(457, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 31);
            this.label14.TabIndex = 11;
            this.label14.Text = "Chat Box";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.employeeinfoBindingSource;
            this.listBox1.DisplayMember = "Employee_ID";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(719, 315);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 284);
            this.listBox1.TabIndex = 6;
            this.listBox1.ValueMember = "Employee_ID";
            this.listBox1.Click += new System.EventHandler(this.userInfoGet);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(719, 622);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 38);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(611, 620);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(86, 43);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 20;
            this.listMessage.Location = new System.Drawing.Point(31, 75);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(641, 524);
            this.listMessage.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(31, 620);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(574, 43);
            this.textMessage.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textFriendPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textFriendIp);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(692, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reciver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // textFriendPort
            // 
            this.textFriendPort.Enabled = false;
            this.textFriendPort.Location = new System.Drawing.Point(148, 76);
            this.textFriendPort.Name = "textFriendPort";
            this.textFriendPort.Size = new System.Drawing.Size(164, 26);
            this.textFriendPort.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // textFriendIp
            // 
            this.textFriendIp.Enabled = false;
            this.textFriendIp.Location = new System.Drawing.Point(148, 39);
            this.textFriendIp.Name = "textFriendIp";
            this.textFriendIp.Size = new System.Drawing.Size(164, 26);
            this.textFriendIp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(692, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Enabled = false;
            this.textLocalPort.Location = new System.Drawing.Point(151, 78);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(164, 26);
            this.textLocalPort.TabIndex = 1;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Enabled = false;
            this.textLocalIp.Location = new System.Drawing.Point(151, 41);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(164, 26);
            this.textLocalIp.TabIndex = 0;
            // 
            // employee_infoTableAdapter
            // 
            this.employee_infoTableAdapter.ClearBeforeFill = true;
            // 
            // EmailAndChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1059, 741);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "EmailAndChat";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.EmailAndChat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmail.ResumeLayout(false);
            this.tabPageEmail.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecendUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrentUser)).EndInit();
            this.tabPageSendChat.ResumeLayout(false);
            this.tabPageSendChat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmail;
        private System.Windows.Forms.TabPage tabPageSendChat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFriendPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFriendIp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUserName2;
        private System.Windows.Forms.TextBox textBoxUserEmail2;
        private System.Windows.Forms.TextBox textCurrentUserName;
        private System.Windows.Forms.TextBox textCurrentUserEmail;
        private System.Windows.Forms.ComboBox comboBoxEditId;
        private System.Windows.Forms.PictureBox pictureSecendUser;
        private System.Windows.Forms.PictureBox pictureCurrentUser;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private HMR_DBDataSet hMR_DBDataSet;
        private System.Windows.Forms.BindingSource employeeinfoBindingSource;
        private HMR_DBDataSetTableAdapters.Employee_infoTableAdapter employee_infoTableAdapter;
    }
}