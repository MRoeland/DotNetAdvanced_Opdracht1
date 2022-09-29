namespace Oefening5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(68, 42);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(44, 15);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(237, 42);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(43, 74);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(100, 23);
            this.tbCelsius.TabIndex = 2;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(214, 74);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.tbFahrenheit.TabIndex = 3;
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(53, 124);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(75, 23);
            this.btnCtoF.TabIndex = 4;
            this.btnCtoF.Text = "C to F";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(225, 124);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(75, 23);
            this.btnFtoC.TabIndex = 5;
            this.btnFtoC.Text = "F to C";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 159);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCelsius;
        private Label lblFahrenheit;
        private TextBox tbCelsius;
        private TextBox tbFahrenheit;
        private Button btnCtoF;
        private Button btnFtoC;
    }
}