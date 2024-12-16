using DevExpress.XtraEditors;
using FerreteriaApp.bdatosfer;
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
    public partial class frmReporteComprasUsuarioEntreFechas : MetroFramework.Forms.MetroForm
    {
        clsReportes reportes = new clsReportes();
        public frmReporteComprasUsuarioEntreFechas()
        {
            InitializeComponent();
        }
        // Método para cargar el MetroComboBox con los datos de XPCollectionUsuarios
        private void CargarUsuariosEnComboBox()
        {
            try
            {
                // Suponiendo que tienes un XPCollectionUsuarios que contiene los objetos Usuario
                // Se carga el ComboBox con los usuarios
                mcbUsuarios.Items.Clear(); // Limpiar antes de cargar

                foreach (Usuario usuario in xpCollectionUsuarios)
                {
                    // Asignar al ComboBox el campo que deseas mostrar y el valor asociado
                    mcbUsuarios.Items.Add(new { Text = usuario.NombreCompleto, Value = usuario.IdUsuario });
                }

                // Establecer el DisplayMember y ValueMember del ComboBox
                mcbUsuarios.DisplayMember = "Text"; // El texto que se muestra
                mcbUsuarios.ValueMember = "Value";  // El valor que se guarda internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }
        private void CargarGrid()
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
                // Verificar si se ha seleccionado un usuario
                if (mcbUsuarios.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Obtener el ID del usuario seleccionado desde el ComboBox
                var usuarioSeleccionado = (dynamic)mcbUsuarios.SelectedItem;
                int idUsuario = usuarioSeleccionado.Value;

                // Obtener los datos del procedimiento almacenado
                DataTable compras = reportes.ObtenerComprasEntreFechasPorUsuario(idUsuario,fechaInicio, fechaFin);

                // Asignar los datos al GridControl
                gridControl1.DataSource = compras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void frmReporteComprasUsuarioEntreFechas_Load(object sender, EventArgs e)
        {
            // Cargar los usuarios en el ComboBox
            CargarUsuariosEnComboBox();
        }

        private void mbObtener_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}