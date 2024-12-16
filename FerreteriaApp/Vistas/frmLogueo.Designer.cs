namespace FerreteriaApp.Vistas
{
    partial class frmLogueo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogueo));
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.teUsername = new MetroFramework.Controls.MetroTextBox();
            this.tePwd = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIngresar.Location = new System.Drawing.Point(20, 307);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(360, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Entrar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // teUsername
            // 
            // 
            // 
            // 
            this.teUsername.CustomButton.Image = null;
            this.teUsername.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.teUsername.CustomButton.Name = "";
            this.teUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.teUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.teUsername.CustomButton.TabIndex = 1;
            this.teUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.teUsername.CustomButton.UseSelectable = true;
            this.teUsername.CustomButton.Visible = false;
            this.teUsername.Lines = new string[0];
            this.teUsername.Location = new System.Drawing.Point(150, 214);
            this.teUsername.MaxLength = 50;
            this.teUsername.Name = "teUsername";
            this.teUsername.PasswordChar = '\0';
            //this.teUsername.PromptText = "Usuario";
            this.teUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.teUsername.SelectedText = "";
            this.teUsername.SelectionLength = 0;
            this.teUsername.SelectionStart = 0;
            this.teUsername.ShortcutsEnabled = true;
            this.teUsername.Size = new System.Drawing.Size(100, 25);
            this.teUsername.TabIndex = 0;
            this.teUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.teUsername.UseSelectable = true;
            this.teUsername.WaterMark = "Usuario";
            this.teUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.teUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tePwd
            // 
            // 
            // 
            // 
            this.tePwd.CustomButton.Image = null;
            this.tePwd.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tePwd.CustomButton.Name = "";
            this.tePwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tePwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tePwd.CustomButton.TabIndex = 1;
            this.tePwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tePwd.CustomButton.UseSelectable = true;
            this.tePwd.CustomButton.Visible = false;
            this.tePwd.Lines = new string[0];
            this.tePwd.Location = new System.Drawing.Point(150, 258);
            this.tePwd.MaxLength = 50;
            this.tePwd.Name = "tePwd";
            this.tePwd.PasswordChar = '*';
            //this.tePwd.PromptText = "Contraseña";
            this.tePwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tePwd.SelectedText = "";
            this.tePwd.SelectionLength = 0;
            this.tePwd.SelectionStart = 0;
            this.tePwd.ShortcutsEnabled = true;
            this.tePwd.Size = new System.Drawing.Size(100, 25);
            this.tePwd.TabIndex = 1;
            this.tePwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tePwd.UseSelectable = true;
            this.tePwd.WaterMark = "Contraseña";
            this.tePwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tePwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(95, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(FerreteriaApp.bdatosfer.Usuario);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // frmLogueo
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tePwd);
            this.Controls.Add(this.teUsername);
            this.Controls.Add(this.btnIngresar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogueo";
            this.Text = "FERRETERIA SYS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Shown += new System.EventHandler(this.frmLogueo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroTextBox teUsername;
        private MetroFramework.Controls.MetroTextBox tePwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}