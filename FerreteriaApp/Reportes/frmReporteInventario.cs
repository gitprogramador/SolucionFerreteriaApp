using DevExpress.XtraEditors;
using FerreteriaApp.DatosReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Reportes
{
    public partial class frmReporteInventario : MetroFramework.Forms.MetroForm
    {
        private clsReportes reportes = new clsReportes(); // Instancia de la clase clsReportes

        public frmReporteInventario()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CargarReporteInventario();
        }
        private void CargarReporteInventario()
        {
            try
            {
                // Obtener los datos del procedimiento almacenado
                DataTable ventas = reportes.ObtenerInventario();

                // Asignar los datos al GridControl
                gridControl1.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

    }
}