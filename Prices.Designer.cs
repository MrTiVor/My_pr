namespace My_project
{
    partial class Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prices));
            this.label1 = new System.Windows.Forms.Label();
            this.arenda_bus = new System.Windows.Forms.Label();
            this.arenda_minibus = new System.Windows.Forms.Label();
            this.arenda_taxi = new System.Windows.Forms.Label();
            this.input_price_bus = new System.Windows.Forms.Label();
            this.input_price_minibus = new System.Windows.Forms.Label();
            this.input_price_taxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимости аренды трансопрта (за 1 час):";
            // 
            // arenda_bus
            // 
            this.arenda_bus.AutoSize = true;
            this.arenda_bus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_bus.Location = new System.Drawing.Point(52, 64);
            this.arenda_bus.Name = "arenda_bus";
            this.arenda_bus.Size = new System.Drawing.Size(83, 22);
            this.arenda_bus.TabIndex = 1;
            this.arenda_bus.Text = "Автобус:";
            // 
            // arenda_minibus
            // 
            this.arenda_minibus.AutoSize = true;
            this.arenda_minibus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_minibus.Location = new System.Drawing.Point(52, 97);
            this.arenda_minibus.Name = "arenda_minibus";
            this.arenda_minibus.Size = new System.Drawing.Size(140, 22);
            this.arenda_minibus.TabIndex = 2;
            this.arenda_minibus.Text = "Микроавтобус:";
            // 
            // arenda_taxi
            // 
            this.arenda_taxi.AutoSize = true;
            this.arenda_taxi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_taxi.Location = new System.Drawing.Point(52, 131);
            this.arenda_taxi.Name = "arenda_taxi";
            this.arenda_taxi.Size = new System.Drawing.Size(64, 22);
            this.arenda_taxi.TabIndex = 3;
            this.arenda_taxi.Text = "Такси";
            // 
            // input_price_bus
            // 
            this.input_price_bus.AutoSize = true;
            this.input_price_bus.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_price_bus.Location = new System.Drawing.Point(261, 63);
            this.input_price_bus.Name = "input_price_bus";
            this.input_price_bus.Size = new System.Drawing.Size(122, 23);
            this.input_price_bus.TabIndex = 4;
            this.input_price_bus.Text = "цена_аренды";
            this.input_price_bus.Click += new System.EventHandler(this.input_price_bus_Click);
            // 
            // input_price_minibus
            // 
            this.input_price_minibus.AutoSize = true;
            this.input_price_minibus.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_price_minibus.Location = new System.Drawing.Point(261, 96);
            this.input_price_minibus.Name = "input_price_minibus";
            this.input_price_minibus.Size = new System.Drawing.Size(122, 23);
            this.input_price_minibus.TabIndex = 5;
            this.input_price_minibus.Text = "цена_аренды";
            // 
            // input_price_taxi
            // 
            this.input_price_taxi.AutoSize = true;
            this.input_price_taxi.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_price_taxi.Location = new System.Drawing.Point(261, 131);
            this.input_price_taxi.Name = "input_price_taxi";
            this.input_price_taxi.Size = new System.Drawing.Size(122, 23);
            this.input_price_taxi.TabIndex = 6;
            this.input_price_taxi.Text = "цена_аренды";
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.input_price_taxi);
            this.Controls.Add(this.input_price_minibus);
            this.Controls.Add(this.input_price_bus);
            this.Controls.Add(this.arenda_taxi);
            this.Controls.Add(this.arenda_minibus);
            this.Controls.Add(this.arenda_bus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цены на аренду";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prices_FormClosed);
            this.Load += new System.EventHandler(this.Prices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arenda_bus;
        private System.Windows.Forms.Label arenda_minibus;
        private System.Windows.Forms.Label arenda_taxi;
        private System.Windows.Forms.Label input_price_bus;
        private System.Windows.Forms.Label input_price_minibus;
        private System.Windows.Forms.Label input_price_taxi;
    }
}