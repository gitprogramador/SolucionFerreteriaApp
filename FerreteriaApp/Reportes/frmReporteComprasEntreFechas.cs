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
    public partial class frmReporteComprasEntreFechas : MetroFramework.Forms.MetroForm
    {
        clsReportes reportes = new clsReportes();
        public frmReporteComprasEntreFechas()
        {
            InitializeComponent();
        }
        private void CargarComprasEnGrid()
        {
            try
            {
                // Obtener las fechas seleccionadas por el usuario
                DateTime fechaInicio = mdtInicial.Value.Date; // Fecha inicial a las 00:00:00
                DateTime fechaFin = mdtFinal.Value.Date.AddDays(1).AddSeconds(-1); // Fecha final a las 23:59:59

                // Validar que la fecha final no sea menor que la fecha inicial
                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor a la fecha inicial. Por favor, seleccione un rango de fechas válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los datos del procedimiento almacenado
                DataTable compras = reportes.ObtenerComprasEntreFechas(fechaInicio, fechaFin);

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
            CargarComprasEnGrid();
        }

        private void mbExportar_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}