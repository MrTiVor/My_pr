namespace My_project
{
    partial class Data_input
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bus_lease = new System.Windows.Forms.RadioButton();
            this.minibus_lease = new System.Windows.Forms.RadioButton();
            this.taxi_lease = new System.Windows.Forms.RadioButton();
            this.input_time = new System.Windows.Forms.TextBox();
            this.button_OK_data_input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время аренды авто, в часах (целое число)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип аредуемой техники (только один):";
            // 
            // bus_lease
            // 
            this.bus_lease.AutoSize = true;
            this.bus_lease.Location = new System.Drawing.Point(49, 147);
            this.bus_lease.Name = "bus_lease";
            this.bus_lease.Size = new System.Drawing.Size(66, 17);
            this.bus_lease.TabIndex = 2;
            this.bus_lease.TabStop = true;
            this.bus_lease.Text = "Автобус";
            this.bus_lease.UseVisualStyleBackColor = true;
            this.bus_lease.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // minibus_lease
            // 
            this.minibus_lease.AutoSize = true;
            this.minibus_lease.Location = new System.Drawing.Point(49, 170);
            this.minibus_lease.Name = "minibus_lease";
            this.minibus_lease.Size = new System.Drawing.Size(98, 17);
            this.minibus_lease.TabIndex = 3;
            this.minibus_lease.TabStop = true;
            this.minibus_lease.Text = "Микроавтобус";
            this.minibus_lease.UseVisualStyleBackColor = true;
            this.minibus_lease.CheckedChanged += new System.EventHandler(this.minibus_lease_CheckedChanged);
            // 
            // taxi_lease
            // 
            this.taxi_lease.AutoSize = true;
            this.taxi_lease.Location = new System.Drawing.Point(49, 193);
            this.taxi_lease.Name = "taxi_lease";
            this.taxi_lease.Size = new System.Drawing.Size(56, 17);
            this.taxi_lease.TabIndex = 4;
            this.taxi_lease.TabStop = true;
            this.taxi_lease.Text = "Такси";
            this.taxi_lease.UseVisualStyleBackColor = true;
            this.taxi_lease.CheckedChanged += new System.EventHandler(this.taxi_lease_CheckedChanged);
            // 
            // input_time
            // 
            this.input_time.Location = new System.Drawing.Point(487, 52);
            this.input_time.Name = "input_time";
            this.input_time.Size = new System.Drawing.Size(100, 20);
            this.input_time.TabIndex = 5;
            // 
            // button_OK_data_input
            // 
            this.button_OK_data_input.Location = new System.Drawing.Point(511, 225);
            this.button_OK_data_input.Name = "button_OK_data_input";
            this.button_OK_data_input.Size = new System.Drawing.Size(75, 23);
            this.button_OK_data_input.TabIndex = 6;
            this.button_OK_data_input.Text = "OK";
            this.button_OK_data_input.UseVisualStyleBackColor = true;
            this.button_OK_data_input.Click += new System.EventHandler(this.button_OK_data_input_Click);
            // 
            // Data_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 260);
            this.Controls.Add(this.button_OK_data_input);
            this.Controls.Add(this.input_time);
            this.Controls.Add(this.taxi_lease);
            this.Controls.Add(this.minibus_lease);
            this.Controls.Add(this.bus_lease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_input";
            this.Text = "Ввод данных аренды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bus_lease;
        private System.Windows.Forms.RadioButton minibus_lease;
        private System.Windows.Forms.RadioButton taxi_lease;
        private System.Windows.Forms.TextBox input_time;
        private System.Windows.Forms.Button button_OK_data_input;
    }
}