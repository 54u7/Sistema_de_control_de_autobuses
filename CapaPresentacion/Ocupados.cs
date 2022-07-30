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

    public partial class Ocupados : Form
    {
        EntidadesClass objEntidad = new EntidadesClass();
        NegocioClass objNegocio = new NegocioClass();
        public Ocupados()
        {
            InitializeComponent();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            dgvOcupados.DataSource = objNegocio.ListarDatosOcupado("");
        }

        private void Ocupados_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
