namespace Olimpijada
{
    partial class DodajPostojecegSportistu
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnZemlja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPredZemlju = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(255, 415);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 30;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(305, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Baza : Sportisti";
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
            this.listView1.Location = new System.Drawing.Point(47, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 307);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(422, 415);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 32;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // DodajPostojecegSportistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Name = "DodajPostojecegSportistu";
            this.Text = "DodajPostojecegSportistu";
            this.Load += new System.EventHandler(this.DodajPostojecegSportistu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnZemlja;
        private System.Windows.Forms.ColumnHeader columnLime;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnInic;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnPredZemlju;
        private System.Windows.Forms.Button buttonObrisi;
    }
}