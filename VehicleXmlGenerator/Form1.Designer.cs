namespace VehicleXmlGenerator
{
    partial class Form1
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
            this.Dp_min = new System.Windows.Forms.Label();
            this.Dp_max = new System.Windows.Forms.Label();
            this.rt_max = new System.Windows.Forms.Label();
            this.Rt_min = new System.Windows.Forms.Label();
            this.tb_dp_min = new System.Windows.Forms.TextBox();
            this.tb_dp_max = new System.Windows.Forms.TextBox();
            this.tb_rt_min = new System.Windows.Forms.TextBox();
            this.tb_rt_max = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.vehiclenum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox_enabledgv = new System.Windows.Forms.CheckBox();
            this.Acceleration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decceleration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinGap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dp_min
            // 
            this.Dp_min.AutoSize = true;
            this.Dp_min.Location = new System.Drawing.Point(29, 32);
            this.Dp_min.Name = "Dp_min";
            this.Dp_min.Size = new System.Drawing.Size(58, 13);
            this.Dp_min.TabIndex = 0;
            this.Dp_min.Text = "Depart min";
            // 
            // Dp_max
            // 
            this.Dp_max.AutoSize = true;
            this.Dp_max.Location = new System.Drawing.Point(26, 54);
            this.Dp_max.Name = "Dp_max";
            this.Dp_max.Size = new System.Drawing.Size(61, 13);
            this.Dp_max.TabIndex = 1;
            this.Dp_max.Text = "Depart max";
            this.Dp_max.Click += new System.EventHandler(this.label2_Click);
            // 
            // rt_max
            // 
            this.rt_max.AutoSize = true;
            this.rt_max.Location = new System.Drawing.Point(230, 54);
            this.rt_max.Name = "rt_max";
            this.rt_max.Size = new System.Drawing.Size(59, 13);
            this.rt_max.TabIndex = 3;
            this.rt_max.Text = "Route Max";
            this.rt_max.Click += new System.EventHandler(this.label3_Click);
            // 
            // Rt_min
            // 
            this.Rt_min.AutoSize = true;
            this.Rt_min.Location = new System.Drawing.Point(230, 32);
            this.Rt_min.Name = "Rt_min";
            this.Rt_min.Size = new System.Drawing.Size(56, 13);
            this.Rt_min.TabIndex = 2;
            this.Rt_min.Text = "Route Min";
            this.Rt_min.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_dp_min
            // 
            this.tb_dp_min.Location = new System.Drawing.Point(103, 24);
            this.tb_dp_min.Name = "tb_dp_min";
            this.tb_dp_min.Size = new System.Drawing.Size(100, 20);
            this.tb_dp_min.TabIndex = 4;
            // 
            // tb_dp_max
            // 
            this.tb_dp_max.Location = new System.Drawing.Point(103, 51);
            this.tb_dp_max.Name = "tb_dp_max";
            this.tb_dp_max.Size = new System.Drawing.Size(100, 20);
            this.tb_dp_max.TabIndex = 5;
            // 
            // tb_rt_min
            // 
            this.tb_rt_min.Location = new System.Drawing.Point(333, 24);
            this.tb_rt_min.Name = "tb_rt_min";
            this.tb_rt_min.Size = new System.Drawing.Size(100, 20);
            this.tb_rt_min.TabIndex = 6;
            // 
            // tb_rt_max
            // 
            this.tb_rt_max.Location = new System.Drawing.Point(333, 51);
            this.tb_rt_max.Name = "tb_rt_max";
            this.tb_rt_max.Size = new System.Drawing.Size(100, 20);
            this.tb_rt_max.TabIndex = 7;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(680, 24);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 20);
            this.tb_num.TabIndex = 8;
            // 
            // vehiclenum
            // 
            this.vehiclenum.AutoSize = true;
            this.vehiclenum.Location = new System.Drawing.Point(607, 24);
            this.vehiclenum.Name = "vehiclenum";
            this.vehiclenum.Size = new System.Drawing.Size(61, 13);
            this.vehiclenum.TabIndex = 9;
            this.vehiclenum.Text = "vehiclenum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Acceleration,
            this.Decceleration,
            this.ID,
            this.Length,
            this.MinGap,
            this.MaxSpeed,
            this.Sigma,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(29, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 250);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBox_enabledgv
            // 
            this.checkBox_enabledgv.AutoSize = true;
            this.checkBox_enabledgv.Location = new System.Drawing.Point(32, 89);
            this.checkBox_enabledgv.Name = "checkBox_enabledgv";
            this.checkBox_enabledgv.Size = new System.Drawing.Size(104, 17);
            this.checkBox_enabledgv.TabIndex = 12;
            this.checkBox_enabledgv.Text = "Enable DataGrid";
            this.checkBox_enabledgv.UseVisualStyleBackColor = true;
            this.checkBox_enabledgv.CheckedChanged += new System.EventHandler(this.checkBox_enabledgv_CheckedChanged);
            // 
            // Acceleration
            // 
            this.Acceleration.HeaderText = "Accel";
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Decceleration
            // 
            this.Decceleration.HeaderText = "Deccel";
            this.Decceleration.Name = "Decceleration";
            this.Decceleration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // Length
            // 
            this.Length.HeaderText = "length";
            this.Length.Name = "Length";
            this.Length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Length.Width = 50;
            // 
            // MinGap
            // 
            this.MinGap.HeaderText = "MinGap";
            this.MinGap.Name = "MinGap";
            this.MinGap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.HeaderText = "MaxSpeed";
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sigma
            // 
            this.Sigma.HeaderText = "Sigma";
            this.Sigma.Name = "Sigma";
            this.Sigma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sigma.Width = 50;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 416);
            this.Controls.Add(this.checkBox_enabledgv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vehiclenum);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_rt_max);
            this.Controls.Add(this.tb_rt_min);
            this.Controls.Add(this.tb_dp_max);
            this.Controls.Add(this.tb_dp_min);
            this.Controls.Add(this.rt_max);
            this.Controls.Add(this.Rt_min);
            this.Controls.Add(this.Dp_max);
            this.Controls.Add(this.Dp_min);
            this.Name = "Form1";
            this.Text = "Sumo Vehicle XML Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dp_min;
        private System.Windows.Forms.Label Dp_max;
        private System.Windows.Forms.Label rt_max;
        private System.Windows.Forms.Label Rt_min;
        private System.Windows.Forms.TextBox tb_dp_min;
        private System.Windows.Forms.TextBox tb_dp_max;
        private System.Windows.Forms.TextBox tb_rt_min;
        private System.Windows.Forms.TextBox tb_rt_max;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label vehiclenum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_enabledgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decceleration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinGap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

