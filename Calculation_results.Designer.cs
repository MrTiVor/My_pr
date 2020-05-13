namespace My_project
{
    partial class Calculation_results
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
            this.arenda_choise_result = new System.Windows.Forms.Label();
            this.arenda_time_result = new System.Windows.Forms.Label();
            this.arenda_price_result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // arenda_choise_result
            // 
            this.arenda_choise_result.AllowDrop = true;
            this.arenda_choise_result.AutoSize = true;
            this.arenda_choise_result.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.arenda_choise_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_choise_result.Location = new System.Drawing.Point(25, 19);
            this.arenda_choise_result.Name = "arenda_choise_result";
            this.arenda_choise_result.Size = new System.Drawing.Size(290, 25);
            this.arenda_choise_result.TabIndex = 0;
            this.arenda_choise_result.Text = "Вы выбрали для аренды: ";
            this.arenda_choise_result.Click += new System.EventHandler(this.arenda_choise_result_Click);
            // 
            // arenda_time_result
            // 
            this.arenda_time_result.AllowDrop = true;
            this.arenda_time_result.AutoSize = true;
            this.arenda_time_result.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.arenda_time_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_time_result.Location = new System.Drawing.Point(30, 62);
            this.arenda_time_result.Name = "arenda_time_result";
            this.arenda_time_result.Size = new System.Drawing.Size(231, 24);
            this.arenda_time_result.TabIndex = 1;
            this.arenda_time_result.Text = "Длительность аренды: ";
            this.arenda_time_result.Click += new System.EventHandler(this.arenda_time_result_Click);
            // 
            // arenda_price_result
            // 
            this.arenda_price_result.AllowDrop = true;
            this.arenda_price_result.AutoSize = true;
            this.arenda_price_result.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.arenda_price_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_price_result.Location = new System.Drawing.Point(30, 109);
            this.arenda_price_result.Name = "arenda_price_result";
            this.arenda_price_result.Size = new System.Drawing.Size(200, 24);
            this.arenda_price_result.TabIndex = 2;
            this.arenda_price_result.Text = "Стоимость аренды: ";
            this.arenda_price_result.Click += new System.EventHandler(this.arenda_price_result_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_project.Properties.Resources.шеринг;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(564, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Calculation_results
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 159);
            this.Controls.Add(this.arenda_price_result);
            this.Controls.Add(this.arenda_time_result);
            this.Controls.Add(this.arenda_choise_result);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Calculation_results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты данных";
            this.Load += new System.EventHandler(this.Calculation_results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arenda_choise_result;
        private System.Windows.Forms.Label arenda_time_result;
        private System.Windows.Forms.Label arenda_price_result;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}