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
            this.SuspendLayout();
            // 
            // arenda_choise_result
            // 
            this.arenda_choise_result.AutoSize = true;
            this.arenda_choise_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_choise_result.Location = new System.Drawing.Point(12, 28);
            this.arenda_choise_result.Name = "arenda_choise_result";
            this.arenda_choise_result.Size = new System.Drawing.Size(283, 25);
            this.arenda_choise_result.TabIndex = 0;
            this.arenda_choise_result.Text = "Вы выбрали арендовать ";
            // 
            // arenda_time_result
            // 
            this.arenda_time_result.AutoSize = true;
            this.arenda_time_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_time_result.Location = new System.Drawing.Point(17, 71);
            this.arenda_time_result.Name = "arenda_time_result";
            this.arenda_time_result.Size = new System.Drawing.Size(224, 24);
            this.arenda_time_result.TabIndex = 1;
            this.arenda_time_result.Text = "Длительность аренды ";
            // 
            // arenda_price_result
            // 
            this.arenda_price_result.AutoSize = true;
            this.arenda_price_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arenda_price_result.Location = new System.Drawing.Point(17, 118);
            this.arenda_price_result.Name = "arenda_price_result";
            this.arenda_price_result.Size = new System.Drawing.Size(193, 24);
            this.arenda_price_result.TabIndex = 2;
            this.arenda_price_result.Text = "Стоимость аренды ";
            // 
            // Calculation_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.arenda_price_result);
            this.Controls.Add(this.arenda_time_result);
            this.Controls.Add(this.arenda_choise_result);
            this.Name = "Calculation_results";
            this.Text = "Результаты данных";
            this.Load += new System.EventHandler(this.Calculation_results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arenda_choise_result;
        private System.Windows.Forms.Label arenda_time_result;
        private System.Windows.Forms.Label arenda_price_result;
    }
}