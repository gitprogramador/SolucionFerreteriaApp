using DevExpress.Data.Filtering;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FerreteriaApp.Vistas
{
    public partial class frmVentas : MetroFramework.Forms.MetroForm
    {
        List<Detalle_venta> detalle;
        private int IdUsuario;
        public frmVentas(int idUsuario)
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            detalle = new List<Detalle_venta>();
            Limpiar();
            this.IdUsuario = idUsuario;
        }
        #region Metodos
        private void ActualizarTotal()
        {
            // Calcular la suma de los subtotales en la lista de detalles
            decimal total = detalle.Sum(d => d.SubTotal);

            // Mostrar el total en el control teTotal
            teTotal.Text = total.ToString("N2"); // Formato con 2 decimales
        }

        private void Limpiar()
        {
            slueProductos.EditValue = null;
            slueCliente.EditValue = null;
            teCantidad.Clear();
            tePrecioVenta.Clear();
            tePago.Clear();
            teCambio.Clear();
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
            tePrecioVenta.Clear();
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
        private void CargarClientes()
        {
            try
            {
                // Filtrar productos activos
                xpCollectionClientes.Criteria = CriteriaOperator.Parse("Estado == 1");

                // Verificar si hay productos después del filtro
                if (xpCollectionClientes.Count > 0)
                {
                    // Asignar los datos al SearchLookupEdit
                    slueCliente.Properties.DataSource = xpCollectionClientes;
                    slueCliente.Properties.DisplayMember = "NombreCompleto"; // Campo visible en el control
                    slueCliente.Properties.ValueMember = "IdCliente";       // Campo para el valor seleccionado

                    // Configurar las columnas visibles del control
                    slueCliente.Properties.PopulateViewColumns();
                    slueCliente.Properties.View.Columns["IdCliente"].Visible = false; // Ocultar el ID si no es necesario
                }
                else
                {
                    // Opcional: Mensaje o lógica si no hay productos activos
                    MessageBox.Show("No hay Clients activos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al cargar los Clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarStockProductos(Detalle_venta productoDetalle, int cantidadVendida)
        {
            // Buscar el producto correspondiente en la colección xpCollectionProductos
            Producto producto = xpCollectionProductos.Cast<Producto>().FirstOrDefault(p => p.IdProducto == productoDetalle.IdProducto.IdProducto);

            if (producto != null)
            {
                // Asegurarse de que la cantidad vendida no sea mayor que el stock disponible
                if (producto.Stock >= cantidadVendida)
                {
                    // Restar la cantidad vendida del stock
                    producto.Stock -= cantidadVendida;

                    // Guardar los cambios en el producto
                    producto.Save();
                }
                else
                {
                    // Si no hay suficiente stock, puedes manejar el error o lanzar una excepción
                    throw new InvalidOperationException("No hay suficiente stock disponible para la venta.");
                }
            }
            else
            {
                // Si no se encuentra el producto, lanzar un error o manejarlo de alguna manera
                throw new InvalidOperationException("Producto no encontrado.");
            }

            // Refrescar la vista de productos
            slueProductos.Properties.View.RefreshData();
        }


        private void RestaurarStockProducto(Detalle_venta productoDetalle)
        {
            // Buscar el producto correspondiente en la colección xpCollectionProductos
            Producto producto = xpCollectionProductos.Cast<Producto>().FirstOrDefault(p => p.IdProducto == productoDetalle.IdProducto.IdProducto);

            if (producto != null)
            {
                // Restaurar la cantidad al stock
                producto.Stock += productoDetalle.Cantidad;

                // Guardar los cambios en el producto
                producto.Save();
            }

            // Refrescar la vista de productos
            slueProductos.Properties.View.RefreshData();
        }


        #endregion

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void slueViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                tePrecioVenta.Text = slueViewProductos.GetFocusedRowCellValue("PrecioVenta").ToString();
                teCantidad.Select();
            }
            else
            {
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
            if (string.IsNullOrEmpty(teCantidad.Text) || string.IsNullOrEmpty(tePrecioVenta.Text))
            {
                MessageBox.Show("Ingrese la cantidad y el precio de venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(teCantidad.Text, out int cantidad) || !decimal.TryParse(tePrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("Cantidad y Precio deben ser valores numéricos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cantidad <= 0 || precioVenta <= 0)
            {
                MessageBox.Show("Cantidad y Precio deben ser mayores a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Si la cantidad solicitada es mayor al stock disponible, mostrar un mensaje de error
            if (productoSeleccionado.Stock < cantidad)
            {
                MessageBox.Show($"No se puede vender {cantidad} unidades. Solo quedan {productoSeleccionado.Stock} unidades disponibles.",
                                 "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarAlAgregarProducto();
                return;
            }


            bool productoEncontrado = false;
            Detalle_venta detalleProductoExistente = null;

            foreach (var detalleVenta in detalle)
            {
                if (detalleVenta.IdProducto == productoSeleccionado)
                {
                    // Si el producto ya existe, actualizar su cantidad y subtotal
                    detalleVenta.Cantidad += cantidad;
                    detalleVenta.SubTotal = detalleVenta.Cantidad * detalleVenta.PrecioVenta;

                    // Marcar como encontrado
                    productoEncontrado = true;

                    // Guardar el detalle para la actualización de stock después del foreach
                    detalleProductoExistente = detalleVenta;
                    break;  // Salir del foreach si ya encontramos el producto
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no existe en el detalle, agregarlo como nuevo detalle
                Detalle_venta newDV = new Detalle_venta(unitOfWork1)
                {
                    IdProducto = productoSeleccionado,
                    Cantidad = cantidad,
                    PrecioVenta = precioVenta,
                    SubTotal = cantidad * precioVenta
                };
                detalle.Add(newDV);

                // Actualizar el stock para el nuevo detalle
                ActualizarStockProductos(newDV, cantidad);
            }
            else
            {
                // Actualizar el stock para el producto existente solo una vez
                ActualizarStockProductos(detalleProductoExistente, cantidad);
            }



            // Refrescar el grid
            gridControl1.RefreshDataSource();

            // Calcular el total
            ActualizarTotal();
            // Limpiar los campos del producto
            LimpiarAlAgregarProducto();
            // Si el stock es bajo (por ejemplo, menos de 10 unidades), mostrar advertencia
            if (productoSeleccionado.Stock <= 10)
            {
                MessageBox.Show($"Solo quedan {productoSeleccionado.Stock} unidades de este producto.","Stock Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

                // Validar que un cliente esté seleccionado
                if (slueCliente.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validar que el monto de pago sea suficiente
                if (!decimal.TryParse(tePago.Text, out decimal montoPago) || !decimal.TryParse(teTotal.Text, out decimal total) || montoPago < total)
                {
                    MessageBox.Show("El monto de pago no es suficiente para cubrir el total.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Buscar el usuario en la colección
                var usuario = xpCollection1.OfType<Usuario>()
                    .FirstOrDefault(u => u.IdUsuario == IdUsuario);
                // Crear la instancia de la venta
                Venta v = new Venta(unitOfWork1)
                {
                    IdUsuario = usuario,
                    IdCliente = (Cliente)slueViewClientes.GetFocusedRow(),
                    MontoPago = montoPago,
                    MontoCambio = Convert.ToDecimal(teCambio.Text),
                    MontoTotal = total,
                };

                // Agregar los detalles de la venta
                foreach (Detalle_venta detalleVenta in detalle)
                {
                    detalleVenta.IdVenta = v;
                    v.Detalle_ventas.Add(detalleVenta); // Suponiendo que tienes una relación en la entidad
                }

                // Guardar los cambios en la base de datos
                unitOfWork1.CommitChanges();

                // Mostrar mensaje de éxito
                MessageBox.Show("La venta se ha procesado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImprimirUltimaFactura();
                // Limpiar el formulario para una nueva venta
                Limpiar();
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Ocurrió un error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Después de guardar la venta
                foreach (Detalle_venta detalleVenta in detalle)
                {
                    // Obtener el producto relacionado
                    Producto producto = detalleVenta.IdProducto;

                    if (producto != null)
                    {
                        // Reducir el stock según la cantidad vendida
                        producto.Stock -= detalleVenta.Cantidad;

                        // Validar que el stock no sea negativo
                        if (producto.Stock < 0)
                        {
                            throw new Exception($"El stock del producto '{producto.Nombre}' es insuficiente.");
                        }

                        // Guardar los cambios en el producto
                        producto.Save();
                    }
                }

                // Confirmar cambios en la base de datos
                unitOfWork1.CommitChanges();

                // Mensaje de éxito
                MessageBox.Show("El stock de los productos ha sido actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error al actualizar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tePago_TextChanged(object sender, EventArgs e)
        {
            // Validar si el monto de pago y el total son válidos
            if (decimal.TryParse(tePago.Text, out decimal montoPago) && decimal.TryParse(teTotal.Text, out decimal total))
            {
                // Calcular el cambio
                decimal cambio = montoPago - total;

                // Mostrar el cambio en el campo teCambio (evitando valores negativos)
                teCambio.Text = (cambio >= 0 ? cambio : 0).ToString("N2"); // Formato con 2 decimales
            }
            else
            {
                // Si los valores no son válidos, limpiar el campo teCambio
                teCambio.Text = "0.00";
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Obtener el producto seleccionado
                Detalle_venta productoSeleccionado = gridView1.GetFocusedRow() as Detalle_venta;
                if (productoSeleccionado != null)
                {
                    // Obtener el IdProducto directamente
                    Producto idProductoSeleccionado = productoSeleccionado.IdProducto;

                    // Comparar el IdProducto con los elementos en detalle
                    Detalle_venta productoDetalle = detalle.FirstOrDefault(d => d.IdProducto == idProductoSeleccionado);

                    if (productoDetalle != null)
                    {
                        // Antes de eliminar, restaurar el stock
                        RestaurarStockProducto(productoDetalle);  // Llamar al método para restaurar el stock
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

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            // Buscar el usuario en la colección
            var usuario = xpCollection1.OfType<Usuario>()
                .FirstOrDefault(u => u.IdUsuario == IdUsuario);

            if (usuario != null)
            {
                // Obtener el rol del usuario
                Rol rol = usuario.IdRol; // Asumiendo que Usuario tiene una propiedad llamada "Rol" de tipo Rol

                // Pasar el rol al formulario de clientes
                frmClientes frm = new frmClientes(rol);
                frm.ShowDialog();

                // Recargar la colección de clientes
                xpCollectionClientes.Reload();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirUltimaFactura()
        {
            try
            {
                // Obtener la última factura agregada
                var ultimaCompra = unitOfWork1.Query<Venta>()
                    .OrderByDescending(c => c.IdVenta) // Asegúrate de usar el identificador único o timestamp adecuado
                    .FirstOrDefault();

                if (ultimaCompra == null)
                {
                    MessageBox.Show("No se encontró ninguna factura para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar el texto del ticket
                StringBuilder ticket = new StringBuilder();
                ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                ticket.AppendLine($"Cliente:\n {ultimaCompra.IdCliente.NombreCompleto}");
                ticket.AppendLine($"Atendido por:\n {ultimaCompra.IdUsuario.NombreCompleto}");
                ticket.AppendLine("------------------");
                ticket.AppendLine("DETALLE DE VENTA");
                ticket.AppendLine("------------------");

                foreach (var detalle in ultimaCompra.Detalle_ventas)
                {
                    ticket.AppendLine($"{detalle.IdProducto.Nombre}");
                    ticket.AppendLine($"  Cantidad: {detalle.Cantidad} x {detalle.PrecioVenta:C}");
                    ticket.AppendLine($"  Subtotal: {(detalle.Cantidad * detalle.PrecioVenta):C}");
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