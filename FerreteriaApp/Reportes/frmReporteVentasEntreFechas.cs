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
    public partial class frmReporteVentasEntreFechas : MetroFramework.Forms.MetroForm
    {
        clsReportes reportes = new clsReportes();
        public frmReporteVentasEntreFechas()
        {
            InitializeComponent();
        }
        private void CargarVentasEnGrid()
        {
            try
            {
                // Obtener las fechas seleccionadas por el usuario
                DateTime fechaInicio = mdtInicial.Value;
                DateTime fechaFin = mdtFinal.Value;

                // Validar que la fecha final no sea menor que la fecha inicial
                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor a la fecha inicial. Por favor, seleccione un rango de fechas válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método sin cargar los datos
                }

                // Obtener los datos del procedimiento almacenado
                DataTable compras = reportes.ObtenerVentasEntreFechas(fechaInicio, fechaFin);

                // Asignar los datos al GridControl
                gridControl1.DataSource = compras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void mbObtener_Click(object sender, EventArgs e)
        {
            CargarVentasEnGrid();
        }

        private void mbExportar_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();

        }
    }
}