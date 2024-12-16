using DevExpress.Data.Filtering;
using DevExpress.Xpo;
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
    public partial class frmUsuarios : MetroFramework.Forms.MetroForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Botones(true,false,false,false,false,false, false);
            CargarUsuarios();
        }
        #region Metodos
        private void CargarUsuarios()
        {
            // Establece el filtro directamente en el xpCollection para excluir los usuarios con IdRol igual a 4
            xpCollectionUsuarios.Criteria = CriteriaOperator.Parse("IdRol <> 4");

            // Asigna el xpCollection filtrado como fuente de datos del GridControl
            gridControl1.DataSource = xpCollectionUsuarios;
        }

        private void Limpiar()
        {
            teNombreCompleto.Clear();
            teUsuario.Clear();
            tePwd.Clear();
            cbeRol.EditValue = false;
            teNombreCompleto.Focus();
        }
        private void Botones(bool nuevo,bool guardar,bool actualizar,bool eliminar, bool cancelar,bool campos,bool estado)
        {
            sbNuevo.Enabled = nuevo;
            sbGuardar.Enabled = guardar;
            sbActualizar.Enabled = actualizar;
            sbEliminar.Enabled = eliminar;
            sbCancelar.Enabled = cancelar;
            teNombreCompleto.Enabled = campos;
            teUsuario.Enabled = campos;
            tePwd.Enabled= campos;
            cbeRol.Enabled= campos;
            sbCambiarEstado.Enabled = estado;
        }
        #endregion

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(false,true,false,false,true,true,false);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones(true, false, false, false, false,false, false);
        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {
            string nombre = teNombreCompleto.Text;
            string usuario = teUsuario.Text;
            string pwd = tePwd.Text;
            Rol rol = (Rol)slueRol.GetFocusedRow();
            if (rol == null && string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Campos Requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Usuario newuser = new Usuario(unitOfWork1)
                {
                    NombreCompleto = nombre,
                    Username = usuario,
                    Pwd = EncriptacionPwd.EncryptPassword(pwd),
                    IdRol = rol,
                    Estado = 1
                };
                newuser.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                CargarUsuarios();
                Botones(true,false, false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(e.RowHandle>=0)
            {
                teNombreCompleto.Text = gridView1.GetFocusedRowCellValue("NombreCompleto").ToString();
                teUsuario.Text = gridView1.GetFocusedRowCellValue("Username").ToString();
                cbeRol.EditValue = gridView1.GetFocusedRowCellValue("IdRol!Key");
                Botones(false, false, true, true, true,true, true);
            }
        }

        private void sbActualizar_Click(object sender, EventArgs e)
        {
            string nombre = teNombreCompleto.Text;
            string usuario = teUsuario.Text;
            string pwd = tePwd.Text;
         
            if (gridView1.GetFocusedRow() == null || cbeRol.EditValue == null || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Seleccione un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Usuario userSeleccionado = (Usuario)gridView1.GetFocusedRow();
            string oldPwd = userSeleccionado.Pwd;
            string newPwd = pwd.Trim();
            try
            {
                userSeleccionado.NombreCompleto = nombre;
                userSeleccionado.Username = usuario;
                userSeleccionado.IdRol = xpCollectionRoles.OfType<Rol>().FirstOrDefault(rol => rol.IdRol == (int)cbeRol.EditValue);
                if (string.IsNullOrEmpty(newPwd))
                {
                    userSeleccionado.Pwd = oldPwd;
                }
                else
                {
                    userSeleccionado.Pwd = EncriptacionPwd.EncryptPassword( newPwd);
                }


                userSeleccionado.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                CargarUsuarios();
                Botones(true, false, false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbEliminar_Click(object sender, EventArgs e)
        {
            string nombre = teNombreCompleto.Text;
            string usuario = teUsuario.Text;
 
            if (gridView1.GetFocusedRow() == null || cbeRol.EditValue == null || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Usuario userSeleccionado = (Usuario)gridView1.GetFocusedRow();
            try
            {
                userSeleccionado.Delete();
                unitOfWork1.CommitChanges();
                Limpiar();
                CargarUsuarios();
                Botones(true, false, false, false, false,false, false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sbCambiarEstado_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null || cbeRol.EditValue == null || string.IsNullOrEmpty(teNombreCompleto.Text) || string.IsNullOrEmpty(teUsuario.Text))
            {
                MessageBox.Show("Seleccione un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Usuario userSeleccionado = (Usuario)gridView1.GetFocusedRow();
            try
            {
                if(userSeleccionado.Estado == 1)
                {
                    userSeleccionado.Estado = 0;
                }
                else
                {
                    userSeleccionado.Estado = 1;
                }
                userSeleccionado.Save();
                unitOfWork1.CommitChanges();
                Limpiar();
                CargarUsuarios();
                Botones(true, false, false, false, false, false,false);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}