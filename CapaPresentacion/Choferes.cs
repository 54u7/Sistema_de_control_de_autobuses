using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Choferes : Form
    {
        EntidadesClass objEntidad = new EntidadesClass();
        NegocioClass objNegocio = new NegocioClass();
        public Choferes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            //txtBuscar.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtNombre.Focus();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            //CHOFERES
            dgvAgregarChofer.DataSource = objNegocio.ListarDatosChoferes(buscar);

        }

        private void Choferes_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtApellido.Text == "" && dtpNacimiento.Text == "" && txtCedula.Text == "")
            {
                MessageBox.Show("Rellene los campos");
            }
            else
            {
                try
                {
                    objEntidad.Nombre = txtNombre.Text.ToUpper();
                    objEntidad.Apellido = txtApellido.Text.ToUpper();
                    objEntidad.Nacimiento = dtpNacimiento.Text.ToUpper();
                    objEntidad.Cedula = txtCedula.Text.ToUpper();

                    objNegocio.InsertarDatosChoferes(objEntidad);
                    MessageBox.Show("Datos registrados correctamente");
                    mostrarBuscarTabla("");
                    Limpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar el registro " + ex);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
