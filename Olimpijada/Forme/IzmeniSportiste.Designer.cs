namespace Olimpijada
{
    partial class IzmeniSportiste
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZemlja = new System.Windows.Forms.TextBox();
            this.textBoxLime = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxInicijali = new System.Windows.Forms.TextBox();
            this.textBoxPredstavlja = new System.Windows.Forms.TextBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.comboBoxMedalja = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zemlja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licno Ime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inicijali";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Predstavlja Zemlju";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxZemlja
            // 
            this.textBoxZemlja.Location = new System.Drawing.Point(190, 35);
            this.textBoxZemlja.Name = "textBoxZemlja";
            this.textBoxZemlja.Size = new System.Drawing.Size(100, 20);
            this.textBoxZemlja.TabIndex = 5;
            this.textBoxZemlja.TextChanged += new System.EventHandler(this.textBoxZemlja_TextChanged);
            // 
            // textBoxLime
            // 
            this.textBoxLime.Location = new System.Drawing.Point(190, 96);
            this.textBoxLime.Name = "textBoxLime";
            this.textBoxLime.Size = new System.Drawing.Size(100, 20);
            this.textBoxLime.TabIndex = 6;
            this.textBoxLime.TextChanged += new System.EventHandler(this.textBoxLime_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(190, 164);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 7;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxPrezime_TextChanged);
            // 
            // textBoxInicijali
            // 
            this.textBoxInicijali.Location = new System.Drawing.Point(190, 214);
            this.textBoxInicijali.Name = "textBoxInicijali";
            this.textBoxInicijali.Size = new System.Drawing.Size(100, 20);
            this.textBoxInicijali.TabIndex = 8;
            this.textBoxInicijali.TextChanged += new System.EventHandler(this.textBoxInicijali_TextChanged);
            // 
            // textBoxPredstavlja
            // 
            this.textBoxPredstavlja.Location = new System.Drawing.Point(190, 264);
            this.textBoxPredstavlja.Name = "textBoxPredstavlja";
            this.textBoxPredstavlja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredstavlja.TabIndex = 9;
            this.textBoxPredstavlja.TextChanged += new System.EventHandler(this.textBoxPredstavlja_TextChanged);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(135, 397);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(94, 30);
            this.buttonIzmeni.TabIndex = 10;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // comboBoxMedalja
            // 
            this.comboBoxMedalja.FormattingEnabled = true;
            this.comboBoxMedalja.Items.AddRange(new object[] {
            "ZLATO",
            "SREBRO",
            "BRONZA",
            "NIJE OSVOJENA"});
            this.comboBoxMedalja.Location = new System.Drawing.Point(190, 307);
            this.comboBoxMedalja.Name = "comboBoxMedalja";
            this.comboBoxMedalja.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedalja.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Medalja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mesto";
            // 
            // textBoxMesto
            // 
            this.textBoxMesto.Location = new System.Drawing.Point(190, 351);
            this.textBoxMesto.Name = "textBoxMesto";
            this.textBoxMesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesto.TabIndex = 14;
            // 
            // IzmeniSportiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.textBoxMesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMedalja);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.textBoxPredstavlja);
            this.Controls.Add(this.textBoxInicijali);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxLime);
            this.Controls.Add(this.textBoxZemlja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmeniSportiste";
            this.Text = "IzmeniSportiste";
            this.Load += new System.EventHandler(this.IzmeniSportiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZemlja;
        private System.Windows.Forms.TextBox textBoxLime;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxInicijali;
        private System.Windows.Forms.TextBox textBoxPredstavlja;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.ComboBox comboBoxMedalja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMesto;
    }
}