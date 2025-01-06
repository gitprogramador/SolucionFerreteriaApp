using DevExpress.XtraEditors;
using FerreteriaApp.bdatosfer;
using FerreteriaApp.Encriptacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Vistas
{
    public partial class frmProductos : MetroFramework.Forms.MetroForm
    {
        Rol rol;
        public frmProductos(Rol rol)
        {
            InitializeComponent();
            Botones(true, false, false, false, false, false, false);
            this.rol = rol;
        }
        #region Metodos
        private void Permiso(bool p)
        {
            if (p)
            {
                if (rol.IdRol == 2)
                {   
                    Botones(false, false, true, false, true, true, false);
                }
                else if (rol.IdRol == 1)
                {
                    Botones(false, false, true, false, true, true, true);
                }
                else if (rol.IdRol == 3)
                {
                    Botones(false, false, false, false, false, false, false);
                }
                else
                {
                    Botones(false, false, true, true, true, true, true);
                }
            }
            else
            {
                if (rol.IdRol == 2 || rol.IdRol == 1)
                {
                    Botones(true, false, false, false, false, false, false);
                }
                else if (rol.IdRol == 3)
                {
                    Botones(false, false, false, false, false, false, false);
                }
                else
                {
                    Botones(true, false, false, false, false, false, false);
                }
            }
        }
        private void Limpiar()
        {
            teCodigo.Clear();
            teNombre.Clear();
            teDescripcion.Clear();
            teStock.Clear();
            tePrecioC.Clear();
            tePrecioV.Clear();
            slueCategoria.EditValue = null;
            slueMedida.EditValue = null;
            teCodigo.Focus();
        }
        private void Botones(bool nuevo, bool guardar, bool actualizar, bool eliminar, bool cancelar, bool campos, bool estado)
        {
            sbNuevo.Enabled = nuevo;
            sbGuardar.Enabled = guardar;
            sbActualizar.Enabled = actualizar;
            sbEliminar.Enabled = eliminar;
            sbCancelar.Enabled = cancelar;
            teCodigo.Enabled = campos;
            teNombre.Enabled = campos;
            teDescripcion.Enabled = campos;
            teStock.Enabled = campos;
            tePrecioC.Enabled = campos;
            tePrecioV.Enabled = campos;
            slueCategoria.Enabled = campos;
            slueMedida.Enabled = campos;
            sbCambiarEstado.Enabled = estado;
        }
        #endregion

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(false, true, false, false, true, true, false);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(true, false, false, false, false, false, false);
        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teCodigo.Text) | string.IsNullOrEmpty(teNombre.Text) ||
                string.IsNullOrEmpty(teDescripcion.Text) || string.IsNullOrEmpty(teStock.Text) || string.IsNullOrEmpty(tePrecioC.Text) ||
                string.IsNullOrEmpty(tePrecioV.Text) || slueCategoria.EditValue == null && slueMedida.EditValue == null)
            {
                MessageBox.Show("Campos Requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Producto newuser = new Producto(unitOfWork1)
                {
                    Codigo = teCodigo.Text,
                    Nombre = teNombre.Text,
                    Descripcion = teDescripcion.Text,
                    Stock =int.Parse(teStock.Text),
                    PrecioCompra = Convert.ToDecimal(tePrecioC.Text),
                    PrecioVenta = Convert.ToDecimal(tePrecioV.Text),
                    IdCategoria = (Categoria)slueViewCategoria.GetFocusedRow(),
                    IdMedida= (Medida)slueViewMedida.GetFocusedRow(),
                    Estado = 1
                };
                newuser.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollectionProductos.Reload();
                Botones(true, false, false, false, false, false, false);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                teCodigo.Text = gridView1.GetFocusedRowCellValue("Codigo").ToString();
                teNombre.Text = gridView1.GetFocusedRowCellValue("Nombre").ToString();
                teDescripcion.Text = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                teStock.Text = gridView1.GetFocusedRowCellValue("Stock").ToString();
                tePrecioC.Text = gridView1.GetFocusedRowCellValue("PrecioCompra").ToString();
                tePrecioV.Text = gridView1.GetFocusedRowCellValue("PrecioVenta").ToString();
                slueCategoria.EditValue = gridView1.GetFocusedRowCellValue("IdCategoria!Key");
                slueMedida.EditValue = gridView1.GetFocusedRowCellValue("IdMedida!Key");
                Permiso(true);
            }
        }

        private void sbActualizar_Click(object sender, EventArgs e)
        {

            if (gridView1.GetFocusedRow() == null || string.IsNullOrEmpty(teCodigo.Text) || string.IsNullOrEmpty(teNombre.Text) ||
                string.IsNullOrEmpty(teDescripcion.Text) || string.IsNullOrEmpty(teStock.Text) || string.IsNullOrEmpty(tePrecioC.Text) ||
                string.IsNullOrEmpty(tePrecioV.Text) || slueCategoria.EditValue == null || slueMedida.EditValue == null)
            {
                MessageBox.Show("Seleccione un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Producto Seleccionado = (Producto)gridView1.GetFocusedRow();
            try
            {
                Seleccionado.Codigo = teCodigo.Text;
                Seleccionado.Nombre = teNombre.Text;
                Seleccionado.Descripcion = teDescripcion.Text;
                Seleccionado.Stock = int.Parse(teStock.Text);
                Seleccionado.PrecioCompra = Convert.ToDecimal(tePrecioC.Text);
                Seleccionado.PrecioVenta = Convert.ToDecimal(tePrecioV.Text);
                Seleccionado.IdCategoria = xpCollectionCategoria.OfType<Categoria>().FirstOrDefault(cat => cat.IdCategoria == (int)slueCategoria.EditValue);
                Seleccionado.IdMedida = xpCollectionMedidas.OfType<Medida>().FirstOrDefault(med => med.IdMedida == (int)slueMedida.EditValue);
                Seleccionado.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollectionProductos.Reload();
                xpCollectionCategoria.Reload();
                xpCollectionMedidas.Reload();
                Botones(true, false, false, false, false, false, false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbEliminar_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null || string.IsNullOrEmpty(teCodigo.Text)||string.IsNullOrEmpty(teNombre.Text)||
                string.IsNullOrEmpty(teDescripcion.Text)||string.IsNullOrEmpty(teStock.Text)||string.IsNullOrEmpty(tePrecioC.Text)||
                string.IsNullOrEmpty(tePrecioV.Text)||slueCategoria.EditValue==null||slueMedida.EditValue == null)
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Producto Seleccionado = (Producto)gridView1.GetFocusedRow();
            try
            {
                Seleccionado.Delete();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollectionProductos.Reload();
                xpCollectionCategoria.Reload();
                xpCollectionMedidas.Reload();
                Botones(true, false, false, false, false, false, false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbCambiarEstado_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null)
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Producto Seleccionado = (Producto)gridView1.GetFocusedRow();
            try
            {
                if (Seleccionado.Estado == 1)
                {
                    Seleccionado.Estado = 0;
                }
                else
                {
                    Seleccionado.Estado = 1;
                }
                Seleccionado.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollectionProductos.Reload();
                xpCollectionCategoria.Reload();
                xpCollectionMedidas.Reload();
                Botones(true, false, false, false, false, false, false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Permiso(false);
        }
    }
}