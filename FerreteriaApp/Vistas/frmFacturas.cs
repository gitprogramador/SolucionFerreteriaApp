using DevExpress.Xpo;
using DevExpress.XtraEditors;
using FerreteriaApp.bdatosfer;
using FerreteriaApp.DatosReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Vistas
{
    public partial class frmFacturas : MetroFramework.Forms.MetroForm
    {
        private clsReportes reportes = new clsReportes(); // Instancia de la clase clsReportes
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada como DataRow
                DataRow row = gridView1.GetFocusedDataRow(); // Esto obtiene directamente el DataRow de la fila seleccionada

                if (row == null)
                {
                    MessageBox.Show("Seleccione una venta antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método de impresión
                ImprimirUltimaFactura(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirUltimaFactura(DataRow venta)
        {
            try
            {
                if (venta == null)
                {
                    MessageBox.Show("No se encontró ninguna factura para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar el texto del ticket usando el DataRow
                StringBuilder ticket = new StringBuilder();
                ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                ticket.AppendLine($"Cliente: {venta["NombreCliente"]}");  // Cambia "NombreCliente" por el nombre correcto de la columna
                ticket.AppendLine($"Atendido por: {venta["NombreUsuario"]}");  // Cambia "NombreUsuario" por el nombre correcto de la columna
                ticket.AppendLine("------------------");
                ticket.AppendLine("DETALLE DE VENTA");
                ticket.AppendLine("------------------");

                // Aquí debes iterar sobre los detalles de la venta, que también deben estar en un DataTable o DataSet
                DataTable detallesVenta = reportes.ObtenerDetallesVenta(Convert.ToInt32(venta["IdVenta"])); // Método ficticio para obtener detalles

                foreach (DataRow detalle in detallesVenta.Rows)
                {
                    ticket.AppendLine($"{detalle["Producto"]}");  // Cambia "NombreProducto" por el nombre correcto de la columna
                    ticket.AppendLine($"  Cantidad: {detalle["Cantidad"]} x {detalle["PrecioVenta"]:C}");
                    ticket.AppendLine($"  Subtotal: {(Convert.ToDecimal(detalle["Cantidad"]) * Convert.ToDecimal(detalle["PrecioVenta"])):C}");
                }

                ticket.AppendLine("------------------");
                ticket.AppendLine($"TOTAL: {venta["MontoTotal"]:C}");  // Cambia "MontoTotal" por el nombre correcto de la columna
                ticket.AppendLine("------------------");
                ticket.AppendLine("Gracias por su compra!");
                ticket.AppendLine("******************");

                // Imprimir el ticket
                ImprimirTicket(ticket.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al imprimir el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirTicket(string textoTicket)
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();

                // Asignar la fecha y hora actual como nombre del documento
                string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"); // Formato: Año-Mes-Día_Hora-Minuto-Segundo
                printDoc.DocumentName = $"Ticket_{fecha}";

                printDoc.PrintPage += (sender, e) =>
                {
                    // Dibujar el texto del ticket
                    e.Graphics.DrawString(textoTicket, new Font("Courier New", 10), Brushes.Black, new PointF(0, 0));
                };

                // Configurar el tamaño de papel (ticket)
                PaperSize tamañoTicket = new PaperSize("Ticket", 280, 600); // Ajusta el tamaño según tus necesidades
                printDoc.DefaultPageSettings.PaperSize = tamañoTicket;

                // Mostrar el diálogo de impresión
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDoc,
                    UseEXDialog = true // Habilitar opciones avanzadas (como seleccionar impresora virtual)
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print(); // Imprimir o guardar como PDF
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}