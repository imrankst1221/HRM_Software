namespace HRM_SUB
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.employeeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMR_DBDataSet = new HRM_SUB.HMR_DBDataSet();
            this.employee_infoTableAdapter = new HRM_SUB.HMR_DBDataSetTableAdapters.Employee_infoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDepertment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBoxEditId = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMR_DBDataSet3 = new HRM_SUB.HMR_DBDataSet3();
            this.employee_AttendanceTableAdapter = new HRM_SUB.HMR_DBDataSet3TableAdapters.Employee_AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet3)).BeginInit();
            this.SuspendLayout();
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
            // employee_infoTableAdapter
            // 
            this.employee_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 646);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textStatus);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textDepertment);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxEditName);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.comboBoxEditId);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(52, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Total Work hour vs Employee work hour";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Age";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(56, 257);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Age";
            series5.Name = "Total Work Hour";
            series5.YValuesPerPoint = 3;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Age";
            series6.Name = "Employee Work Hour";
            series6.YValuesPerPoint = 3;
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(432, 292);
            this.chart2.TabIndex = 52;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(551, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Agreement vs Current Agreement";
            // 
            // textStatus
            // 
            this.textStatus.Enabled = false;
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(238, 167);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(307, 26);
            this.textStatus.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(40, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Employee Status";
            // 
            // textDepertment
            // 
            this.textDepertment.Enabled = false;
            this.textDepertment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepertment.Location = new System.Drawing.Point(238, 126);
            this.textDepertment.Name = "textDepertment";
            this.textDepertment.Size = new System.Drawing.Size(307, 26);
            this.textDepertment.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(40, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Employee Department";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Enabled = false;
            this.textBoxEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditName.Location = new System.Drawing.Point(238, 81);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(307, 26);
            this.textBoxEditName.TabIndex = 46;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.AliceBlue;
            this.label36.Location = new System.Drawing.Point(40, 83);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(125, 20);
            this.label36.TabIndex = 45;
            this.label36.Text = "Employee Name";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(692, 30);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(160, 160);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.AliceBlue;
            this.label34.Location = new System.Drawing.Point(40, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 20);
            this.label34.TabIndex = 43;
            this.label34.Text = "Employee Id ";
            // 
            // comboBoxEditId
            // 
            this.comboBoxEditId.DataSource = this.employeeinfoBindingSource;
            this.comboBoxEditId.DisplayMember = "Employee_ID";
            this.comboBoxEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditId.FormattingEnabled = true;
            this.comboBoxEditId.Location = new System.Drawing.Point(238, 35);
            this.comboBoxEditId.Name = "comboBoxEditId";
            this.comboBoxEditId.Size = new System.Drawing.Size(307, 28);
            this.comboBoxEditId.TabIndex = 42;
            this.comboBoxEditId.ValueMember = "Employee_ID";
            this.comboBoxEditId.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditId_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Age";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(555, 254);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Age";
            series7.Name = "Total Agreement";
            series7.YValuesPerPoint = 3;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Age";
            series8.Name = "Current Agreement";
            series8.YValuesPerPoint = 3;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(432, 292);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackgroundImage = global::HRM_SUB.Properties.Resources.back;
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Controls.Add(this.textSearch);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendence";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(495, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(101, 26);
            this.Search.TabIndex = 29;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(152, 18);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(329, 26);
            this.textSearch.TabIndex = 28;
            this.textSearch.TextChanged += new System.EventHandler(this.searchData);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.Date,
            this.Start_Time,
            this.End_Time});
            this.dataGridView2.DataSource = this.employeeAttendanceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(152, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 563);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Start_Time
            // 
            this.Start_Time.DataPropertyName = "Start_Time";
            this.Start_Time.HeaderText = "Start_Time";
            this.Start_Time.Name = "Start_Time";
            // 
            // End_Time
            // 
            this.End_Time.DataPropertyName = "End_Time";
            this.End_Time.HeaderText = "End_Time";
            this.End_Time.Name = "End_Time";
            // 
            // employeeAttendanceBindingSource
            // 
            this.employeeAttendanceBindingSource.DataMember = "Employee_Attendance";
            this.employeeAttendanceBindingSource.DataSource = this.hMR_DBDataSet3;
            // 
            // hMR_DBDataSet3
            // 
            this.hMR_DBDataSet3.DataSetName = "HMR_DBDataSet3";
            this.hMR_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_AttendanceTableAdapter
            // 
            this.employee_AttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 646);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMR_DBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HMR_DBDataSet hMR_DBDataSet;
        private System.Windows.Forms.BindingSource employeeinfoBindingSource;
        private HMR_DBDataSetTableAdapters.Employee_infoTableAdapter employee_infoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDepertment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBoxEditId;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HMR_DBDataSet3 hMR_DBDataSet3;
        private System.Windows.Forms.BindingSource employeeAttendanceBindingSource;
        private HMR_DBDataSet3TableAdapters.Employee_AttendanceTableAdapter employee_AttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Time;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textSearch;
    }
}