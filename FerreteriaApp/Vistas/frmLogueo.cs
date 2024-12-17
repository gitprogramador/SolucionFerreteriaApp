﻿using DevExpress.Xpo;
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
    public partial class frmLogueo : MetroFramework.Forms.MetroForm
    {
        public frmLogueo()
        {
            InitializeComponent();
            Limpiar();
        }
        private void Limpiar()
        {
            teUsername.Clear();
            tePwd.Clear();
            teUsername.Focus();
            // Crear un nuevo UnitOfWork y asignarlo al xpCollection
            unitOfWork1 = new UnitOfWork();
            xpCollection1.Session = unitOfWork1;
            xpCollection1.Reload();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = teUsername.Text.Trim();
            string pwd = tePwd.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Campos Requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el usuario en la colección
            var usuarioValido = xpCollection1.OfType<Usuario>()
                .FirstOrDefault(u => u.Username == username);

            // Si el usuario se encuentra y las credenciales son correctas
            if (usuarioValido != null)
            {
                bool pwdValida = EncriptacionPwd.VerifyPassword(pwd, usuarioValido.Pwd);
                if (pwdValida && usuarioValido.Estado == 1)
                {
                    this.Hide();
                    // Crear instancia del formulario Dashboard y mostrarlo
                    frmInicio frm = new frmInicio(usuarioValido.NombreCompleto, usuarioValido.IdRol,usuarioValido);
                    frm.ShowDialog(); // Muestra el Inicio
                    this.Show();
                    this.Activate();
                    Limpiar();
                }
                else if (pwdValida && usuarioValido.Estado == 0)
                {
                    // Contraseña incorrecta
                    MessageBox.Show("Usuario Inactivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                }
                else
                {
                    // Contraseña incorrecta
                    MessageBox.Show("Contraseña incorrecta o Usuario Inactivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Usuario No encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();  // Limpiar los campos
            }

        }

        private void frmLogueo_Shown(object sender, EventArgs e)
        {
            this.Activate(); // Activa el formulario como ventana principal
        }
    }
}