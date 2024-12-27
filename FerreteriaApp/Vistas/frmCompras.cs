using DevExpress.Data.Filtering;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using FerreteriaApp.bdatosfer;
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
    public partial class frmCompras : MetroFramework.Forms.MetroForm
    {
        List<Detalle_compra> detalle;
        private int user;
        public frmCompras(int user)
        {
            InitializeComponent();
            this.detalle = new List<Detalle_compra>();
            CargarProductos();
            CargarProveedores();
            Limpiar();
            this.user = user;
        }
        #region Metodos
        private void ActualizarTotal()
        {
            // Calcular la suma de los subtotales en la lista de detalles
            decimal total = detalle.Sum(d => d.MontoTotal);

            // Mostrar el total en el control teTotal
            teTotal.Text = total.ToString("N2"); // Formato con 2 decimales
        }

        private void Limpiar()
        {
            slueProductos.EditValue = null;
            slueProveedores.EditValue = null;
            teCantidad.Clear();
            tePrecioCompra.Clear();
            tePrecioVenta.Clear();
            teTotal.Clear();
            slueProductos.Focus();
            detalle.Clear();
            gridControl1.DataSource = null; // Desenlaza el grid antes de asignar nuevos datos
            gridControl1.DataSource = detalle; // Asigna nuevamente la lista vacía
        }
        private void LimpiarAlAgregarProducto()
        {
            slueProductos.EditValue = null;
            teCantidad.Clear();
            tePrecioCompra.Clear();
            slueProductos.Focus();
        }
        private void CargarProductos()
        {
            try
            {
                // Filtrar productos activos
                xpCollectionProductos.Criteria = CriteriaOperator.Parse("Estado == 1");
                // Verificar si hay productos después del filtro
                if (xpCollectionProductos.Count > 0)
                {
                    // Asignar los datos al SearchLookupEdit
                    slueProductos.Properties.DataSource = xpCollectionProductos;
                    slueProductos.Properties.DisplayMember = "Nombre"; // Campo visible en el control
                    slueProductos.Properties.ValueMember = "IdProducto";       // Campo para el valor seleccionado

                    // Configurar las columnas visibles del control
                    slueProductos.Properties.PopulateViewColumns();
                    slueProductos.Properties.View.Columns["IdProducto"].Visible = false; // Ocultar el ID si no es necesario
                }
                else
                {
                    // Opcional: Mensaje o lógica si no hay productos activos
                    MessageBox.Show("No hay productos activos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProveedores()
        {
            try
            {
                // Filtrar productos activos
                xpCollectionProveedores.Criteria = CriteriaOperator.Parse("Estado == 1");

                // Verificar si hay productos después del filtro
                if (xpCollectionProveedores.Count > 0)
                {
                    // Asignar los datos al SearchLookupEdit
                    slueProveedores.Properties.DataSource = xpCollectionProveedores;
                    slueProveedores.Properties.DisplayMember = "RazonSocial"; // Campo visible en el control
                    slueProveedores.Properties.ValueMember = "IdProveedor";       // Campo para el valor seleccionado

                    // Configurar las columnas visibles del control
                    slueProveedores.Properties.PopulateViewColumns();
                    slueProveedores.Properties.View.Columns["IdProveedor"].Visible = false; // Ocultar el ID si no es necesario
                }
                else
                {
                    // Opcional: Mensaje o lógica si no hay productos activos
                    MessageBox.Show("No hay proveedores activos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void slueViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                tePrecioCompra.Text = slueViewProductos.GetFocusedRowCellValue("PrecioCompra").ToString();
                tePrecioVenta.Text = slueViewProductos.GetFocusedRowCellValue("PrecioVenta").ToString();
                teCantidad.Select();
            }
            else
            {
                tePrecioCompra.Clear();
                tePrecioVenta.Clear();
            }
        }

        private void sbAgregarProducto_Click(object sender, EventArgs e)
        {
            // Verifica que un producto esté seleccionado
            Producto productoSeleccionado = slueViewProductos.GetFocusedRow() as Producto;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifica cantidad y precio
            if (string.IsNullOrEmpty(teCantidad.Text) || string.IsNullOrEmpty(tePrecioCompra.Text))
            {
                MessageBox.Show("Ingrese la cantidad y el precio de compra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(teCantidad.Text, out int cantidad) || !decimal.TryParse(tePrecioCompra.Text, out decimal precioCompra) || !decimal.TryParse(tePrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("Cantidad y Precio deben ser valores numéricos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cantidad <= 0 || precioCompra <= 0)
            {
                MessageBox.Show("Cantidad y Precio deben ser mayores a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            bool productoEncontrado = false;
            Detalle_compra detalleProductoExistente = null;

            foreach (var detalleCompra in detalle)
            {
                if (detalleCompra.IdProducto == productoSeleccionado)
                {
                    // Si el producto ya existe, actualizar su cantidad y subtotal
                    detalleCompra.Cantidad += cantidad;
                    detalleCompra.PrecioCompra = precioCompra;
                    detalleCompra.PrecioVenta = precioVenta;
                    detalleCompra.MontoTotal = detalleCompra.Cantidad * detalleCompra.PrecioCompra;

                    // Marcar como encontrado
                    productoEncontrado = true;

                    // Guardar el detalle para la actualización de stock después del foreach
                    detalleProductoExistente = detalleCompra;
                    break;  // Salir del foreach si ya encontramos el producto
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no existe en el detalle, agregarlo como nuevo detalle
                Detalle_compra newDV = new Detalle_compra(unitOfWork1)
                {
                    IdProducto = productoSeleccionado,
                    Cantidad = cantidad,
                    PrecioCompra = precioCompra,
                    PrecioVenta = precioVenta,
                    MontoTotal = cantidad * precioCompra
                };
                detalle.Add(newDV);
            }


            // Refrescar el grid
            gridControl1.RefreshDataSource();

            // Calcular el total
            ActualizarTotal();
            // Limpiar los campos del producto
            LimpiarAlAgregarProducto();

        }

        private void sbProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya productos en el detalle
                if (detalle == null || !detalle.Any())
                {
                    MessageBox.Show("Debe agregar al menos un producto para procesar la venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Validar que un proveedor esté seleccionado
                if (slueProveedores.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!decimal.TryParse(teTotal.Text, out decimal total) || total <= 0)
                {
                    MessageBox.Show("El monto de pago debe ser un valor numérico mayor que 0.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Buscar el usuario en la colección
                var usuario = xpCollection1.OfType<Usuario>()
                    .FirstOrDefault(u => u.IdUsuario == user);
                // Crear la instancia de la venta
                Compra v = new Compra(unitOfWork1)
                {
                    IdUsuario = usuario,
                    IdProveedor = (Proveedor)slueViewProveedores.GetFocusedRow(),
                    MontoTotal = total,
                };

                // Agregar los detalles de la venta
                foreach (Detalle_compra detalleCompra in detalle)
                {
                    // Obtener el producto relacionado
                    Producto producto = detalleCompra.IdProducto;
                    detalleCompra.IdCompra = v;
                    v.Detalle_compras.Add(detalleCompra); // Suponiendo que tienes una relación en la entidad
                    if (producto != null)
                    {
                        // sumar el stock según la cantidad vendida
                        producto.Stock += detalleCompra.Cantidad;
                        producto.PrecioCompra = detalleCompra.PrecioCompra;
                        producto.PrecioVenta = detalleCompra.PrecioVenta;
                        // Guardar los cambios en el producto
                        producto.Save();
                    }
                }
                // Guardar los cambios en la base de datos
                unitOfWork1.CommitChanges();

                // Mostrar mensaje de éxito
                MessageBox.Show("La compra se ha procesado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImprimirUltimaFactura();
                // Limpiar el formulario para una nueva venta
                Limpiar();
                xpCollectionProductos.Reload();
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Ocurrió un error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Obtener el producto seleccionado
                Detalle_compra productoSeleccionado = gridView1.GetFocusedRow() as Detalle_compra;
                if (productoSeleccionado != null)
                {
                    // Obtener el IdProducto directamente
                    Producto idProductoSeleccionado = productoSeleccionado.IdProducto;

                    // Comparar el IdProducto con los elementos en detalle
                    Detalle_compra productoDetalle = detalle.FirstOrDefault(d => d.IdProducto == idProductoSeleccionado);

                    if (productoDetalle != null)
                    {
                        xpCollectionProductos.Reload();
                        // Eliminar el producto de la lista de detalle
                        detalle.Remove(productoDetalle);

                        // Refrescar el grid para reflejar el cambio
                        gridControl1.RefreshDataSource();

                        // Si el RefreshDataSource no actualiza el control, prueba reasignando el datasource
                        gridControl1.DataSource = null;
                        gridControl1.DataSource = detalle;

                        // Actualizar el total
                        ActualizarTotal();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado en el detalle.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún producto.");
                }
            }
        }




        private void ImprimirUltimaFactura()
        {
            try
            {
                // Obtener la última factura agregada
                var ultimaCompra = unitOfWork1.Query<Compra>()
                    .OrderByDescending(c => c.IdCompra) // Asegúrate de usar el identificador único o timestamp adecuado
                    .FirstOrDefault();

                if (ultimaCompra == null)
                {
                    MessageBox.Show("No se encontró ninguna factura para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar el texto del ticket
                StringBuilder ticket = new StringBuilder();
                ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                ticket.AppendLine($"Proveedor:\n {ultimaCompra.IdProveedor.RazonSocial}");
                ticket.AppendLine($"Atendido por:\n {ultimaCompra.IdUsuario.NombreCompleto}");
                ticket.AppendLine("------------------");
                ticket.AppendLine("DETALLE DE LA COMPRA");
                ticket.AppendLine("------------------");

                foreach (var detalle in ultimaCompra.Detalle_compras)
                {
                    ticket.AppendLine($"{detalle.IdProducto.Nombre}");
                    ticket.AppendLine($"  Cantidad: {detalle.Cantidad} x {detalle.PrecioCompra:C}");
                    ticket.AppendLine($"  Subtotal: {(detalle.Cantidad * detalle.PrecioCompra):C}");
                }

                ticket.AppendLine("------------------");
                ticket.AppendLine($"TOTAL: {ultimaCompra.MontoTotal:C}");
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


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirUltimaFactura();
        }
    }
}