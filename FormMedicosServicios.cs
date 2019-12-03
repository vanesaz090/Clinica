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
    public partial class FormMedicosServicios : Form
    {
        public FormMedicosServicios()
        {
            InitializeComponent();
        }
        MedicosServiciosNegocio MedicosServicios = new MedicosServiciosNegocio();
        private void FormMedicosServicios_Load(object sender, EventArgs e)
        {

            DataTable dt = MedicosServicios.Select();
            dgvMedicosServicios.DataSource = dt;
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void dgvMedicosServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
