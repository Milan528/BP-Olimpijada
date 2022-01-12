using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Olimpijada
{
    public partial class InfoTakmicenja : Form
    {
        int idTakmicenja;
      
        public InfoTakmicenja(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        private void buttonDodajSportistu_Click(object sender, EventArgs e)
        {
            Sportisti sportisti = new Sportisti(idTakmicenja);
           
            sportisti.ShowDialog();
        }

        private void buttonDodajSudiju_Click(object sender, EventArgs e)
        {
            SudijeForma sudijeForma = new SudijeForma(idTakmicenja);
            sudijeForma.ShowDialog();
        }

        private void buttonDodajDisciplinu_Click(object sender, EventArgs e)
        {
            DisciplinaForma disciplinaForma = new DisciplinaForma(idTakmicenja);
            disciplinaForma.ShowDialog();
        }

        private void buttonZemlje_Click(object sender, EventArgs e)
        {
            FormaZemlja formaZemlja = new FormaZemlja(idTakmicenja);
            formaZemlja.ShowDialog();

        }
    }
}
