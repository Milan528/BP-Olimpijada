namespace Olimpijada
{
    partial class DisciplinaForma
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSportisti = new System.Windows.Forms.Button();
            this.buttonPostojece = new System.Windows.Forms.Button();
            this.buttonSport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(33, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(732, 293);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 53;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ime";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Svetski rekord";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Olimpijski rekord";
            this.columnHeader9.Width = 109;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Proslogodisnji rezultat";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Svetski sampion";
            this.columnHeader11.Width = 103;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Olimpijski sampion";
            this.columnHeader12.Width = 118;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(810, 226);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(92, 23);
            this.buttonObrisi.TabIndex = 20;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(810, 197);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(92, 23);
            this.buttonIzmeni.TabIndex = 19;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(810, 139);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(92, 23);
            this.buttonDodaj.TabIndex = 18;
            this.buttonDodaj.Text = "Dodaj ";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(300, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Discipline";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Rezultati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSportisti
            // 
            this.buttonSportisti.Location = new System.Drawing.Point(810, 317);
            this.buttonSportisti.Name = "buttonSportisti";
            this.buttonSportisti.Size = new System.Drawing.Size(92, 23);
            this.buttonSportisti.TabIndex = 23;
            this.buttonSportisti.Text = "Sportisti";
            this.buttonSportisti.UseVisualStyleBackColor = true;
            this.buttonSportisti.Click += new System.EventHandler(this.buttonSportisti_Click);
            // 
            // buttonPostojece
            // 
            this.buttonPostojece.Location = new System.Drawing.Point(810, 168);
            this.buttonPostojece.Name = "buttonPostojece";
            this.buttonPostojece.Size = new System.Drawing.Size(92, 23);
            this.buttonPostojece.TabIndex = 24;
            this.buttonPostojece.Text = "Dodaj postojecu";
            this.buttonPostojece.UseVisualStyleBackColor = true;
            this.buttonPostojece.Click += new System.EventHandler(this.buttonPostojece_Click);
            // 
            // buttonSport
            // 
            this.buttonSport.Location = new System.Drawing.Point(810, 346);
            this.buttonSport.Name = "buttonSport";
            this.buttonSport.Size = new System.Drawing.Size(92, 23);
            this.buttonSport.TabIndex = 25;
            this.buttonSport.Text = "Sportovi";
            this.buttonSport.UseVisualStyleBackColor = true;
            this.buttonSport.Click += new System.EventHandler(this.buttonSport_Click);
            // 
            // DisciplinaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.buttonSport);
            this.Controls.Add(this.buttonPostojece);
            this.Controls.Add(this.buttonSportisti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Name = "DisciplinaForma";
            this.Text = "DisciplinaForma";
            this.Load += new System.EventHandler(this.DisciplinaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSportisti;
        private System.Windows.Forms.Button buttonPostojece;
        private System.Windows.Forms.Button buttonSport;
    }
}