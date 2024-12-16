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
    public partial class frmCategorias : MetroFramework.Forms.MetroForm
    {
        Rol rol;
        public frmCategorias(Rol rol)
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
                if (rol.IdRol == 2)
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
            teDescripcion.Clear();
            teDescripcion.Focus();
        }
        private void Botones(bool nuevo, bool guardar, bool actualizar, bool eliminar, bool cancelar, bool campos,bool estado)
        {
            sbNuevo.Enabled = nuevo;
            sbGuardar.Enabled = guardar;
            sbActualizar.Enabled = actualizar;
            sbEliminar.Enabled = eliminar;
            sbCancelar.Enabled = cancelar;
            teDescripcion.Enabled = campos;
            sbCambiarEstado.Enabled = estado;
        }
        #endregion

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(false, true, false, false, true, true,false);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(true, false, false, false, false, false, false);
        }

        private void sbCambiarEstado_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null || string.IsNullOrEmpty(teDescripcion.Text))
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Categoria Seleccionado = (Categoria)gridView1.GetFocusedRow();
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
                xpCollection1.Reload();
                Botones(true, false, false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                teDescripcion.Text = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                Permiso(true);
            }
        }

        private void sbEliminar_Click(object sender, EventArgs e)
        {
            string descripcion = teDescripcion.Text;

            if (gridView1.GetFocusedRow() == null ||string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Categoria Seleccionado = (Categoria)gridView1.GetFocusedRow();
            try
            {
                Seleccionado.Delete();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollection1.Reload();
                Botones(true, false, false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbActualizar_Click(object sender, EventArgs e)
        {
            string descripcion = teDescripcion.Text;

            if (gridView1.GetFocusedRow() == null || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Categoria Seleccionado = (Categoria)gridView1.GetFocusedRow();
            try
            {
                Seleccionado.Descripcion = descripcion;
                Seleccionado.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollection1.Reload();
                Botones(true, false, false, false, false, false, false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = teDescripcion.Text;
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Campos Requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Categoria nuevo = new Categoria(unitOfWork1)
                {
                    Descripcion = descripcion,
                    Estado = 1
                };
                nuevo.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                xpCollection1.Reload();
                Botones(true,false,false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            Permiso(false);
        }
    }
}