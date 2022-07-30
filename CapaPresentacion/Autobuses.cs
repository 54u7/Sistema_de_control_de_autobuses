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
    public partial class Autobuses : Form
    {
        EntidadAutobuses objEntidadAutobus = new EntidadAutobuses();
        NegocioClass objNegocio = new NegocioClass();
        public Autobuses()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            //txtBuscar.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtAño.Text = "";
            txtPlaca.Text = "";
            txtColor.Text = "";
            txtAño.Focus();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            //CHOFERES
            dgvAgregarAutobus.DataSource = objNegocio.ListarDatosAutobuses(buscar);

        }

        private void btnAgregarAutobus_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" && txtModelo.Text == "" && txtColor.Text == "" && txtAño.Text == "" && txtPlaca.Text == "")
            {
                MessageBox.Show("Rellene los campos");
            }
            else
            {
                try
                {
                    objEntidadAutobus.Marca = txtMarca.Text.ToUpper();
                    objEntidadAutobus.Modelo = txtModelo.Text.ToUpper();
                    objEntidadAutobus.Color = txtColor.Text.ToUpper();
                    objEntidadAutobus.Placa = txtAño.Text.ToUpper();
                    objEntidadAutobus.Año = txtPlaca.Text.ToUpper();

                    objNegocio.InsertarDatosAutobuses(objEntidadAutobus);

                    MessageBox.Show("Datos registrados correctamente");
                    mostrarBuscarTabla("");
                    Limpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void Autobuses_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
