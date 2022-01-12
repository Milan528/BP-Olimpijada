namespace Olimpijada
{
    partial class InfoTakmicenja
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
            this.buttonDodajSportistu = new System.Windows.Forms.Button();
            this.buttonDodajDisciplinu = new System.Windows.Forms.Button();
            this.buttonDodajSudiju = new System.Windows.Forms.Button();
            this.buttonZemlje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajSportistu
            // 
            this.buttonDodajSportistu.Location = new System.Drawing.Point(110, 64);
            this.buttonDodajSportistu.Name = "buttonDodajSportistu";
            this.buttonDodajSportistu.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajSportistu.TabIndex = 0;
            this.buttonDodajSportistu.Text = "Sportisti";
            this.buttonDodajSportistu.UseVisualStyleBackColor = true;
            this.buttonDodajSportistu.Click += new System.EventHandler(this.buttonDodajSportistu_Click);
            // 
            // buttonDodajDisciplinu
            // 
            this.buttonDodajDisciplinu.Location = new System.Drawing.Point(110, 141);
            this.buttonDodajDisciplinu.Name = "buttonDodajDisciplinu";
            this.buttonDodajDisciplinu.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajDisciplinu.TabIndex = 1;
            this.buttonDodajDisciplinu.Text = "Discipline";
            this.buttonDodajDisciplinu.UseVisualStyleBackColor = true;
            this.buttonDodajDisciplinu.Click += new System.EventHandler(this.buttonDodajDisciplinu_Click);
            // 
            // buttonDodajSudiju
            // 
            this.buttonDodajSudiju.Location = new System.Drawing.Point(110, 214);
            this.buttonDodajSudiju.Name = "buttonDodajSudiju";
            this.buttonDodajSudiju.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajSudiju.TabIndex = 2;
            this.buttonDodajSudiju.Text = "Sudije";
            this.buttonDodajSudiju.UseVisualStyleBackColor = true;
            this.buttonDodajSudiju.Click += new System.EventHandler(this.buttonDodajSudiju_Click);
            // 
            // buttonZemlje
            // 
            this.buttonZemlje.Location = new System.Drawing.Point(110, 280);
            this.buttonZemlje.Name = "buttonZemlje";
            this.buttonZemlje.Size = new System.Drawing.Size(75, 23);
            this.buttonZemlje.TabIndex = 3;
            this.buttonZemlje.Text = "Zemlje";
            this.buttonZemlje.UseVisualStyleBackColor = true;
            this.buttonZemlje.Click += new System.EventHandler(this.buttonZemlje_Click);
            // 
            // InfoTakmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 380);
            this.Controls.Add(this.buttonZemlje);
            this.Controls.Add(this.buttonDodajSudiju);
            this.Controls.Add(this.buttonDodajDisciplinu);
            this.Controls.Add(this.buttonDodajSportistu);
            this.Name = "InfoTakmicenja";
            this.Text = "PrikaziTakmicenje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajSportistu;
        private System.Windows.Forms.Button buttonDodajDisciplinu;
        private System.Windows.Forms.Button buttonDodajSudiju;
        private System.Windows.Forms.Button buttonZemlje;
    }
}