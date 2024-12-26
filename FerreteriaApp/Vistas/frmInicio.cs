using FerreteriaApp.bdatosfer;
using FerreteriaApp.Gestion_BD;
using FerreteriaApp.Graficos;
using FerreteriaApp.Reportes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FerreteriaApp.Vistas
{
    public partial class frmInicio : MetroFramework.Forms.MetroForm
    {
        #region "Variables"
        Usuario IdUsuario;
        string NombreCompleto;
        Rol Rol;
        #endregion
        public frmInicio(string nombreCompleto, Rol rol, Usuario idUsuario)
        {
            InitializeComponent();
            NombreCompleto = nombreCompleto;
            Rol = rol;
            tsslNombre.Text = "Bienvenido - " + nombreCompleto + " - " + rol.Descripcion;
            IdUsuario = idUsuario;
        }
        #region "Botones de Respaldo y Restauracion"
        private void respaldarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos SQL (*.sql)|*.sql";
            sfd.Title = "Seleccione la ruta de guardado";

            // Establecer el nombre por defecto
            string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombreBaseDeDatos = "bdatosfer"; // Reemplaza con el nombre de tu base de datos
            string nombreArchivo = $"Respaldo_{nombreBaseDeDatos}_{fechaHoraActual}.sql";
            sfd.FileName = nombreArchivo;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = sfd.FileName;
                try
                {
                    Operaciones_Base_de_Datos op = new Operaciones_Base_de_Datos();
                    bool exito = op.RespaldarBaseDeDatos(rutaArchivo);  // Llamada al método correcto

                    if (exito)
                    {
                        MessageBox.Show("Respaldo realizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al realizar el respaldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void restaurarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos SQL (*.sql)|*.sql";
            ofd.Title = "Seleccione el archivo de respaldo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = ofd.FileName;
                try
                {
                    Operaciones_Base_de_Datos op = new Operaciones_Base_de_Datos();
                    bool exito = op.RestaurarBaseDeDatos(rutaArchivo);  // Llamada al método correcto

                    if (exito)
                    {
                        MessageBox.Show("Restauración completada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al restaurar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
        #region "Accesos a los formularios Principales"
        
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios(IdUsuario.IdUsuario);
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes(Rol);
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores(Rol);
            frm.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias(Rol);
            frm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos(Rol);
            frm.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras frm = new frmCompras(IdUsuario.IdUsuario);
            frm.ShowDialog();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas(IdUsuario.IdUsuario);
            frm.ShowDialog();
        }

        #endregion

        #region "Carga de Graficos"
        private void CargarChartProductos()
        {
            clsGraficos graficos = new clsGraficos();
            DataTable productos = graficos.GetProductosStockBajo();

            if (productos.Rows.Count > 0)
            {
                // Limpia las series existentes
                chartControl1.Series.Clear();

                // Crear una nueva serie para mostrar los datos
                DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Stock Actual", DevExpress.XtraCharts.ViewType.Bar);

                // Agregar puntos a la serie desde los datos
                foreach (DataRow row in productos.Rows)
                {
                    string nombreProducto = row["NombreProducto"].ToString(); // Asegúrate que coincide con el procedimiento almacenado
                    int stockActual = Convert.ToInt32(row["Stock Actual"]);
                    series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(nombreProducto, stockActual));
                }

                // Personalizar el gráfico
                series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True; // Mostrar etiquetas
                chartControl1.Series.Add(series);

                // Configurar títulos de los ejes (opcional)
                DevExpress.XtraCharts.XYDiagram diagram = (DevExpress.XtraCharts.XYDiagram)chartControl1.Diagram;
                if (diagram != null)
                {
                    diagram.AxisX.Title.Text = "Productos";
                    diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                    diagram.AxisY.Title.Text = "Cantidad en Stock";
                    diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                }

                // Configurar título del gráfico (opcional)
                chartControl1.Titles.Clear();
                chartControl1.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Productos con Stock Bajo" });
            }
            else
            {
                MessageBox.Show("No hay productos con stock bajo para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarChartProductosPorCategoria()
        {
            clsGraficos graficos = new clsGraficos();
            DataTable productosPorCategoria = graficos.GetProductosPorCategoria();

            if (productosPorCategoria.Rows.Count > 0)
            {
                // Limpia cualquier serie previa del gráfico
                chartControl2.Series.Clear();

                // Crea una nueva serie de tipo Pie (pastel)
                DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Productos por Categoría", DevExpress.XtraCharts.ViewType.Pie);

                // Agrega los datos al gráfico
                foreach (DataRow row in productosPorCategoria.Rows)
                {
                    string categoria = row["Categoria"].ToString();
                    int cantidadProductos = Convert.ToInt32(row["CantidadProductos"]);

                    series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(categoria, cantidadProductos));
                }

                // Configura la serie y agrega al gráfico
                chartControl2.Series.Add(series);

                // Opcional: Habilitar etiquetas con porcentajes en el gráfico de pastel
                DevExpress.XtraCharts.PieSeriesView view = (DevExpress.XtraCharts.PieSeriesView)series.View;
                view.Titles.Add(new DevExpress.XtraCharts.SeriesTitle() { Text = "Distribución de Productos por Categoría" });
                series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

                // Formato de etiquetas (valor y porcentaje)
                DevExpress.XtraCharts.PieSeriesLabel label = (DevExpress.XtraCharts.PieSeriesLabel)series.Label;
                label.TextPattern = "{A}: {VP:p0}"; // {A} = argumento, {VP:p0} = porcentaje con formato de 0 decimales
                                                    // Configurar título del gráfico (opcional)
                chartControl2.Titles.Clear();
                chartControl2.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Productos por Categoria" });
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar en el gráfico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region Permisos
        private void BotonesMenuStrip(bool usuarios,
            bool clientes,bool proveedores,bool categorias,bool productos,
            bool compras,bool ventas,bool operaciones,bool reportes)
        {
            usuariosToolStripMenuItem.Visible = usuarios;
            usuariosToolStripMenuItem.Enabled = usuarios;
            clientesToolStripMenuItem.Visible = clientes;
            clientesToolStripMenuItem.Enabled = clientes;
            proveedoresToolStripMenuItem.Visible = proveedores;
            proveedoresToolStripMenuItem.Enabled = proveedores;
            categoriaToolStripMenuItem.Visible = categorias;
            categoriaToolStripMenuItem.Enabled = categorias;
            productosToolStripMenuItem.Visible = productos;
            productosToolStripMenuItem.Enabled = productos;
            compraToolStripMenuItem.Visible = compras;
            compraToolStripMenuItem.Enabled = compras;
            ventaToolStripMenuItem.Visible = ventas;
            ventaToolStripMenuItem.Enabled= ventas;
            operacionesToolStripMenuItem.Visible = operaciones;
            operacionesToolStripMenuItem.Enabled = operaciones;
            reportesToolStripMenuItem.Visible = reportes;
            reportesToolStripMenuItem.Enabled= reportes;
        }
        private void BotonesReporteVendedor(bool inventario,bool cierre)
        {
            inventarioToolStripMenuItem.Enabled = inventario;
            inventarioToolStripMenuItem.Visible= inventario;
            cierreVentasDelDiaToolStripMenuItem.Enabled = cierre;
            cierreVentasDelDiaToolStripMenuItem.Visible=cierre;
        }
        private void Permisos()
        {
            if (Rol.IdRol == 2)
            {
                BotonesMenuStrip(false, true, true, true, true, true, true, false, true);
                BotonesReporteVendedor(false,false);
            }
            else if (Rol.IdRol == 3)
            {
                BotonesMenuStrip(false, true, true, true, true, false, false, false, false);
            }
            else
            {
                BotonesMenuStrip(true, true, true, true, true, true, true, true, true);
            }
        }
        #endregion
        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Permisos();
            CargarChartProductos();
            CargarChartProductosPorCategoria();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteInventario frm = new frmReporteInventario();
            frm.ShowDialog();
        }

        private void entreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentasEntreFechas frm = new frmReporteVentasEntreFechas();
            frm.ShowDialog();
        }

        private void porUsuariosEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentasUsuarioEntreFechas frm = new frmReporteVentasUsuarioEntreFechas();
            frm.ShowDialog();
        }

        private void eNTREFECHASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteComprasEntreFechas frm = new frmReporteComprasEntreFechas();
            frm.ShowDialog();
        }

        private void pORUSUARIOENTREFECHASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteComprasUsuarioEntreFechas frm = new frmReporteComprasUsuarioEntreFechas();
            frm.ShowDialog();
        }

        private void cierreVentasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentasDia frm =new frmVentasDia();
            frm.ShowDialog();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("¿Desea salir?", "Información",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userAnswer == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
        }
    }
}