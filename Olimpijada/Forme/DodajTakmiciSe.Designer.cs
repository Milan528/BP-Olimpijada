namespace Olimpijada
{
    partial class DodajTakmiciSe
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
            this.columnZemlja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPredZemlju = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelIDSportiste = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLicniRekord = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sportisti";
            // 
            // columnZemlja
            // 
            this.columnZemlja.Text = "Zemlja";
            this.columnZemlja.Width = 87;
            // 
            // columnLime
            // 
            this.columnLime.Text = "Licno Ime";
            this.columnLime.Width = 95;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 84;
            // 
            // columnInic
            // 
            this.columnInic.Text = "Inicijali";
            this.columnInic.Width = 67;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 43;
            // 
            // columnPredZemlju
            // 
            this.columnPredZemlju.Text = "Predstavlja zemlju";
            this.columnPredZemlju.Width = 124;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnZemlja,
            this.columnLime,
            this.columnPrezime,
            this.columnInic,
            this.columnId,
            this.columnPredZemlju});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(21, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(524, 200);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // labelIDSportiste
            // 
            this.labelIDSportiste.AutoSize = true;
            this.labelIDSportiste.Location = new System.Drawing.Point(605, 76);
            this.labelIDSportiste.Name = "labelIDSportiste";
            this.labelIDSportiste.Size = new System.Drawing.Size(59, 13);
            this.labelIDSportiste.TabIndex = 14;
            this.labelIDSportiste.Text = "IDSportiste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Licni Rekord";
            // 
            // textBoxLicniRekord
            // 
            this.textBoxLicniRekord.Location = new System.Drawing.Point(608, 146);
            this.textBoxLicniRekord.Name = "textBoxLicniRekord";
            this.textBoxLicniRekord.Size = new System.Drawing.Size(100, 20);
            this.textBoxLicniRekord.TabIndex = 17;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(348, 334);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 18;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // DodajTakmiciSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxLicniRekord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIDSportiste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "DodajTakmiciSe";
            this.Text = "DodajTakmiciSe";
            this.Load += new System.EventHandler(this.DodajTakmiciSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnZemlja;
        private System.Windows.Forms.ColumnHeader columnLime;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnInic;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnPredZemlju;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelIDSportiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLicniRekord;
        private System.Windows.Forms.Button buttonDodaj;
    }
}