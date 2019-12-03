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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        public static string transaccionesType;

        private void formularioVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set value on transactiontype static method
            transaccionesType = "Visitas realizadas por medicos";
            FormFichaVisita fichavisita = new FormFichaVisita();
            fichavisita.Show();
        }

        private void habioconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set value on transactiontype static method
            transaccionesType = "Ingresar habitacion o consultorio";
            FormHabCons HabCons = new FormHabCons();
            HabCons.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaccionesType = "Medicos con mas servicios";
            FormMedicosServicios MedServicios = new FormMedicosServicios();
            MedServicios.Show();
        }


        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void habioconsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
