using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FormFichaVisita : Form
    {
        public FormFichaVisita()
        {
            InitializeComponent();
        }

        

        FichaTecnicaNegocio FTecnica = new FichaTecnicaNegocio();
        FichaVisita Ficvis = new FichaVisita();


        private void FormFichaVisita_Load(object sender, EventArgs e)
        {
            DataTable dt = FTecnica.Select();
            dgvFichaVisita.DataSource = dt;
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }
    }
}
