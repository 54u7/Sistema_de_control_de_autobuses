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
    public partial class Rutas : Form
    {
        EntidadRutas objRutas = new EntidadRutas();
        EntidadesClass objEntidad = new EntidadesClass();
        NegocioClass objNegocio = new NegocioClass();
        public Rutas()
        {
            InitializeComponent();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            dgvAgregarRutas.DataSource = objNegocio.ListarDatosRutas(buscar);

        }

        private void Limpiar()
        {
            //txtBuscar.Text = "";
            txtRuta.Text = "";
        }

        private void btnAgregarRutas_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text == "")
            {
                MessageBox.Show("Rellene los campos");
            }
            else
            {
                try
                {
                    objRutas.Rutas = txtRuta.Text.ToUpper();

                    objNegocio.InsertarDatosRutas(objRutas);

                    mostrarBuscarTabla("");

                    MessageBox.Show("Registro guardado correctamente");

                    Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar el regustro " + ex);
                }
            }

        }

        private void Rutas_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
