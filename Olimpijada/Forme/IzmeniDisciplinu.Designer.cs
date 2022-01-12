namespace Olimpijada
{
    partial class IzmeniDisciplinu
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
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.textBoxOlimpijskiSmpion = new System.Windows.Forms.TextBox();
            this.textBoxSvetskiSampion = new System.Windows.Forms.TextBox();
            this.textBoxProslogodisnjiRezultat = new System.Windows.Forms.TextBox();
            this.textBoxOlimpijskiRezultat = new System.Windows.Forms.TextBox();
            this.textBoxSvetskiRezultat = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "POJEDINACNA",
            "EKIPNA",
            "KOMBINOVANA"});
            this.comboBoxTip.Location = new System.Drawing.Point(164, 85);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTip.TabIndex = 32;
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(119, 343);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 31;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // textBoxOlimpijskiSmpion
            // 
            this.textBoxOlimpijskiSmpion.Location = new System.Drawing.Point(164, 278);
            this.textBoxOlimpijskiSmpion.Name = "textBoxOlimpijskiSmpion";
            this.textBoxOlimpijskiSmpion.Size = new System.Drawing.Size(100, 20);
            this.textBoxOlimpijskiSmpion.TabIndex = 30;
            // 
            // textBoxSvetskiSampion
            // 
            this.textBoxSvetskiSampion.Location = new System.Drawing.Point(164, 236);
            this.textBoxSvetskiSampion.Name = "textBoxSvetskiSampion";
            this.textBoxSvetskiSampion.Size = new System.Drawing.Size(100, 20);
            this.textBoxSvetskiSampion.TabIndex = 29;
            // 
            // textBoxProslogodisnjiRezultat
            // 
            this.textBoxProslogodisnjiRezultat.Location = new System.Drawing.Point(164, 195);
            this.textBoxProslogodisnjiRezultat.Name = "textBoxProslogodisnjiRezultat";
            this.textBoxProslogodisnjiRezultat.Size = new System.Drawing.Size(100, 20);
            this.textBoxProslogodisnjiRezultat.TabIndex = 28;
            // 
            // textBoxOlimpijskiRezultat
            // 
            this.textBoxOlimpijskiRezultat.Location = new System.Drawing.Point(164, 163);
            this.textBoxOlimpijskiRezultat.Name = "textBoxOlimpijskiRezultat";
            this.textBoxOlimpijskiRezultat.Size = new System.Drawing.Size(100, 20);
            this.textBoxOlimpijskiRezultat.TabIndex = 27;
            // 
            // textBoxSvetskiRezultat
            // 
            this.textBoxSvetskiRezultat.Location = new System.Drawing.Point(164, 127);
            this.textBoxSvetskiRezultat.Name = "textBoxSvetskiRezultat";
            this.textBoxSvetskiRezultat.Size = new System.Drawing.Size(100, 20);
            this.textBoxSvetskiRezultat.TabIndex = 26;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(164, 51);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Olimpijski sampion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Svetski sampion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Proslogodisnji rezultat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Olimpijski rekord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Svetski rekord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ime";
            // 
            // IzmeniDisciplinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 387);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.textBoxOlimpijskiSmpion);
            this.Controls.Add(this.textBoxSvetskiSampion);
            this.Controls.Add(this.textBoxProslogodisnjiRezultat);
            this.Controls.Add(this.textBoxOlimpijskiRezultat);
            this.Controls.Add(this.textBoxSvetskiRezultat);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "IzmeniDisciplinu";
            this.Text = "IzmeniDisciplinu";
            this.Load += new System.EventHandler(this.IzmeniDisciplinu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.TextBox textBoxOlimpijskiSmpion;
        private System.Windows.Forms.TextBox textBoxSvetskiSampion;
        private System.Windows.Forms.TextBox textBoxProslogodisnjiRezultat;
        private System.Windows.Forms.TextBox textBoxOlimpijskiRezultat;
        private System.Windows.Forms.TextBox textBoxSvetskiRezultat;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}