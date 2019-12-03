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
    public partial class FormHabCons : Form
    {
        public FormHabCons()
        {
            InitializeComponent();
        }

        HabConsNegocio HabCon = new HabConsNegocio();
        HabitacionoConsultorio claseHabCon = new HabitacionoConsultorio();
        // FichaVisita Ficvis = new FichaVisita();


        

        private void FormHabCons_Load(object sender, EventArgs e)
        {
            HabCon.llenarItems(comboBoxHABoCON);
            HabCon.llenarItemsPropietarios(comboBoxPropietario);
            HabCon.llenarItemsArrendatario(comboBoxArrendatario);
            HabCon.llenarItemsVivienda(cmbVivienda);
            HabCon.llenarItemsUbicacion(cmbUbicacion);

            DataTable dt = HabCon.Select();
            dgvHabCon.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string NombreUbicacion = cmbUbicacion.Text;
            string NombreDominio = comboBoxHABoCON.Text;
            string TipoVivienda = cmbVivienda.Text;
            string NombrePropietario = comboBoxPropietario.Text;
            string NombreArrendatario = comboBoxArrendatario.Text;



            Ubicacion ubicacion = HabCon.ObtenerIdubicacion(NombreUbicacion);
            tipoVivienda Dominio = HabCon.ObtenerTipoDominio(NombreDominio);
            Vivienda Vivienda = HabCon.ObtenerTipoVivienda(TipoVivienda);
            Propietario Propietario = HabCon.ObteneridPropietario(NombrePropietario);
            Arrendatario Arrendatario = HabCon.ObteneridArrendatario(NombreArrendatario);



            //Getting Data From UI

            claseHabCon.idUbicacion= ubicacion.idUbicacion;
            claseHabCon.idTipo = Dominio.idTipoHabitacionoConsultorio;
            claseHabCon.idTipoVivienda = Vivienda.idTipoVivienda;
            claseHabCon.idPropietario = Propietario.idPropietario;
            claseHabCon.idArrendatario = Arrendatario.idArrendatario;

            claseHabCon.Longitud = txtLongitud.Text;
            claseHabCon.Dotacion = cmbDotacion.Text;
            claseHabCon.Ventanas =bool.Parse(cmbVentanas.Text);
            claseHabCon.ValorMetroCuadrado = txtValMetCua.Text;
            claseHabCon.valorAdministracion = txtValAdministracion.Text;
            claseHabCon.FechaRemodelacion = DateTime.Parse(dateTimeRemodelacion.Text);
            claseHabCon.NombreOcupante = txtOcupante.Text;
            claseHabCon.TiempoOcupaHabitacion = txtTiempoOcupante.Text;


            //Iserting Data into DataBase
            bool success = HabCon.Insert(claseHabCon);
            //Si los datos son INSERTADOS correctamente el valor del success sera verdadero, de lo contrario sera falso
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("DOMINIO AGREGADO CON ÉXITO");
                LimpiarCampos();
            }
            else
            {
                //Failed to insert Data
                MessageBox.Show("FALLO al AGREGAR NUEVO DOMINIO");

            }
            //Refreshing data grid view
            DataTable dt = HabCon.Select();
            dgvHabCon.DataSource = dt;
        }

        private void LimpiarCampos()
        {
            cmbUbicacion.Text = "";
            txtLongitud.Text = "";
            cmbDotacion.Text = "";
            cmbVentanas.Text = "";
            comboBoxHABoCON.Text = "";
            txtValMetCua.Text = "";
            cmbVivienda.Text = "";
            comboBoxPropietario.Text = "";
            comboBoxArrendatario.Text = "";
            txtValAdministracion.Text = "";
            dateTimeRemodelacion.Text = "";
            txtOcupante.Text = "";
            txtTiempoOcupante.Text = "";

        }


        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
