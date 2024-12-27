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
    public partial class frmVentasDia : MetroFramework.Forms.MetroForm
    {
        private clsReportes reportes = new clsReportes(); // Instancia de la clase clsReportes

        public frmVentasDia()
        {
            InitializeComponent();
        }
        private void CargarVentasEnGrid()
        {
            try
            {
                // Obtener los datos del procedimiento almacenado
                DataTable ventas = reportes.ObtenerVentasDelDia();

                // Asignar los datos al GridControl
                gridControl1.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Cargar los datos al cargar el formulario
            CargarVentasEnGrid();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}