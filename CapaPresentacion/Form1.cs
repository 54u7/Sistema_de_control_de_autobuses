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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Disponibles objDisponiblesForm = new Disponibles();

            objDisponiblesForm.Visible = true;

        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            Choferes objChoferesForm = new Choferes();

            objChoferesForm.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Autobuses objAutobusesForm = new Autobuses();

            objAutobusesForm.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rutas objRutasForm = new Rutas();

            objRutasForm.Visible = true;
        }

        private void btnOcupados_Click(object sender, EventArgs e)
        {
            Ocupados objOcupadosForm = new Ocupados();

            objOcupadosForm.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
