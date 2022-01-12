namespace Olimpijada
{
    partial class IzmeniTakmiciSe
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
            this.textBoxLicniRekord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLicniRekord
            // 
            this.textBoxLicniRekord.Location = new System.Drawing.Point(165, 63);
            this.textBoxLicniRekord.Name = "textBoxLicniRekord";
            this.textBoxLicniRekord.Size = new System.Drawing.Size(100, 20);
            this.textBoxLicniRekord.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Licni Rekord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzmeniTakmiciSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLicniRekord);
            this.Controls.Add(this.label3);
            this.Name = "IzmeniTakmiciSe";
            this.Text = "IzmeniTakmiciSe";
            this.Load += new System.EventHandler(this.IzmeniTakmiciSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLicniRekord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}