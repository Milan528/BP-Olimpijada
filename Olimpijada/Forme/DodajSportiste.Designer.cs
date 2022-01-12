namespace Olimpijada
{
    partial class DodajSportiste
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxPredstavlja = new System.Windows.Forms.TextBox();
            this.textBoxInicijali = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxLime = new System.Windows.Forms.TextBox();
            this.textBoxZemlja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.comboBoxMedalja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(179, 408);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(94, 30);
            this.buttonDodaj.TabIndex = 21;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxPredstavlja
            // 
            this.textBoxPredstavlja.Location = new System.Drawing.Point(205, 245);
            this.textBoxPredstavlja.Name = "textBoxPredstavlja";
            this.textBoxPredstavlja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPredstavlja.TabIndex = 20;
            // 
            // textBoxInicijali
            // 
            this.textBoxInicijali.Location = new System.Drawing.Point(205, 183);
            this.textBoxInicijali.Name = "textBoxInicijali";
            this.textBoxInicijali.Size = new System.Drawing.Size(100, 20);
            this.textBoxInicijali.TabIndex = 19;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(205, 135);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 18;
            // 
            // textBoxLime
            // 
            this.textBoxLime.Location = new System.Drawing.Point(205, 85);
            this.textBoxLime.Name = "textBoxLime";
            this.textBoxLime.Size = new System.Drawing.Size(100, 20);
            this.textBoxLime.TabIndex = 17;
            // 
            // textBoxZemlja
            // 
            this.textBoxZemlja.Location = new System.Drawing.Point(205, 32);
            this.textBoxZemlja.Name = "textBoxZemlja";
            this.textBoxZemlja.Size = new System.Drawing.Size(100, 20);
            this.textBoxZemlja.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Predstavlja Zemlju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inicijali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Licno Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zemlja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Medalja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mesto";
            // 
            // textBoxMesto
            // 
            this.textBoxMesto.Location = new System.Drawing.Point(205, 303);
            this.textBoxMesto.Name = "textBoxMesto";
            this.textBoxMesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesto.TabIndex = 26;
            this.textBoxMesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMesto_KeyPress);
            // 
            // comboBoxMedalja
            // 
            this.comboBoxMedalja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedalja.FormattingEnabled = true;
            this.comboBoxMedalja.Items.AddRange(new object[] {
            "ZLATO",
            "SREBRO",
            "BRONZA",
            "NIJE OSVOJENA"});
            this.comboBoxMedalja.Location = new System.Drawing.Point(205, 349);
            this.comboBoxMedalja.Name = "comboBoxMedalja";
            this.comboBoxMedalja.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedalja.TabIndex = 27;
            // 
            // DodajSportiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.comboBoxMedalja);
            this.Controls.Add(this.textBoxMesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDodaj);
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
            this.Name = "DodajSportiste";
            this.Text = "DodajSportiste";
            this.Load += new System.EventHandler(this.DodajSportiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxPredstavlja;
        private System.Windows.Forms.TextBox textBoxInicijali;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxLime;
        private System.Windows.Forms.TextBox textBoxZemlja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMesto;
        private System.Windows.Forms.ComboBox comboBoxMedalja;
    }
}