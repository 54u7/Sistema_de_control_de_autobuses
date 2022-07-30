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
    public partial class Disponibles : Form
    {
        private string Id;

        EntidadOcupados objOcupados = new EntidadOcupados();
        EntidadAutobuses objAutobuses = new EntidadAutobuses();
        EntidadRutas objRutas = new EntidadRutas();
        EntidadesClass objEntidad = new EntidadesClass();
        NegocioClass objNegocio = new NegocioClass();
        public Disponibles()
        {
            InitializeComponent();
            
        }

        public void mostrarBuscarTabla(string buscar)
        {
            //CHOFERES
            dgvChoferDispo.DataSource = objNegocio.ListarDatosChoferes(buscar);
            
            //AUTOBUSES
            dgvAutobusesDispo.DataSource = objNegocio.ListarDatosAutobuses(buscar);

            //RUTAS
            dgvRutasDispo.DataSource = objNegocio.ListarDatosRutas(buscar);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            dgvChoferDispo.ClearSelection();
            dgvAutobusesDispo.ClearSelection();
            dgvRutasDispo.ClearSelection();
        }

        private void Limpiar()
        {
            //txtBuscar.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtMarca.Text = "";           
            txtPlaca.Text = "";
            txtRuta.Text = "";
            
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtCedula.Text == "" &&txtMarca.Text == "" && txtPlaca.Text == "" && txtRuta.Text == "")
            {
                MessageBox.Show("Seleccione los datos a vincular");
            }
            else
            {
                try
                {
                    objOcupados.Nombre = txtNombre.Text.ToUpper();
                    objOcupados.Cedula = txtCedula.Text.ToUpper();
                    objOcupados.Marca = txtMarca.Text.ToUpper();
                    objOcupados.Placa = txtPlaca.Text.ToUpper();
                    objOcupados.Ruta = txtRuta.Text.ToUpper();


                    objNegocio.InsertarDatosOcupado(objOcupados);
                    MessageBox.Show("Datos vinculados correctamente");
                    mostrarBuscarTabla("");


                    objEntidad.Id = Convert.ToInt32(dgvChoferDispo.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarDatosChoferes(objEntidad);

                    objAutobuses.Id = Convert.ToInt32(dgvAutobusesDispo.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarDatosAutobuses(objAutobuses);

                    objRutas.Id = Convert.ToInt32(dgvRutasDispo.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarDatosRuta(objRutas);

                    

                    Limpiar();

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void dgvChoferDispo_MouseClick(object sender, MouseEventArgs e)
        {

            Id = dgvChoferDispo.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvChoferDispo.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dgvChoferDispo.CurrentRow.Cells[4].Value.ToString();

        }

        private void dgvAutobusesDispo_MouseClick(object sender, MouseEventArgs e)
        {
            Id = dgvAutobusesDispo.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = dgvAutobusesDispo.CurrentRow.Cells[1].Value.ToString();
            txtPlaca.Text = dgvAutobusesDispo.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvRutasDispo_MouseClick(object sender, MouseEventArgs e)
        {
            Id = dgvRutasDispo.CurrentRow.Cells[0].Value.ToString();
            txtRuta.Text = dgvRutasDispo.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
