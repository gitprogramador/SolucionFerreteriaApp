namespace FerreteriaApp.Reportes
{
    partial class frmReporteVentasUsuarioEntreFechas
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mcbUsuarios = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mdtFinal = new MetroFramework.Controls.MetroDateTime();
            this.mdtInicial = new MetroFramework.Controls.MetroDateTime();
            this.mbExportar = new MetroFramework.Controls.MetroButton();
            this.mbObtener = new MetroFramework.Controls.MetroButton();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpCollectionUsuarios = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(20, 150);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(668, 397);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(644, 373);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(668, 397);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(648, 377);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mcbUsuarios);
            this.panelControl1.Controls.Add(this.metroLabel3);
            this.panelControl1.Controls.Add(this.metroLabel2);
            this.panelControl1.Controls.Add(this.metroLabel1);
            this.panelControl1.Controls.Add(this.mdtFinal);
            this.panelControl1.Controls.Add(this.mdtInicial);
            this.panelControl1.Controls.Add(this.mbExportar);
            this.panelControl1.Controls.Add(this.mbObtener);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(20, 60);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(668, 90);
            this.panelControl1.TabIndex = 8;
            // 
            // mcbUsuarios
            // 
            this.mcbUsuarios.FormattingEnabled = true;
            this.mcbUsuarios.ItemHeight = 23;
            this.mcbUsuarios.Location = new System.Drawing.Point(276, 37);
            this.mcbUsuarios.Name = "mcbUsuarios";
            this.mcbUsuarios.Size = new System.Drawing.Size(121, 29);
            this.mcbUsuarios.TabIndex = 4;
            this.mcbUsuarios.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(316, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(163, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Fecha Final";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha Inicial";
            // 
            // mdtFinal
            // 
            this.mdtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtFinal.Location = new System.Drawing.Point(145, 37);
            this.mdtFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFinal.Name = "mdtFinal";
            this.mdtFinal.Size = new System.Drawing.Size(116, 29);
            this.mdtFinal.TabIndex = 2;
            // 
            // mdtInicial
            // 
            this.mdtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtInicial.Location = new System.Drawing.Point(5, 37);
            this.mdtInicial.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtInicial.Name = "mdtInicial";
            this.mdtInicial.Size = new System.Drawing.Size(116, 29);
            this.mdtInicial.TabIndex = 2;
            // 
            // mbExportar
            // 
            this.mbExportar.Location = new System.Drawing.Point(518, 37);
            this.mbExportar.Name = "mbExportar";
            this.mbExportar.Size = new System.Drawing.Size(75, 29);
            this.mbExportar.TabIndex = 1;
            this.mbExportar.Text = "Exportar";
            this.mbExportar.UseSelectable = true;
            this.mbExportar.Click += new System.EventHandler(this.mbExportar_Click);
            // 
            // mbObtener
            // 
            this.mbObtener.Location = new System.Drawing.Point(414, 37);
            this.mbObtener.Name = "mbObtener";
            this.mbObtener.Size = new System.Drawing.Size(75, 29);
            this.mbObtener.TabIndex = 0;
            this.mbObtener.Text = "OBTENER";
            this.mbObtener.UseSelectable = true;
            this.mbObtener.Click += new System.EventHandler(this.mbObtener_Click);
            // 
            // xpCollectionUsuarios
            // 
            this.xpCollectionUsuarios.ObjectType = typeof(FerreteriaApp.bdatosfer.Usuario);
            this.xpCollectionUsuarios.Session = this.unitOfWork1;
            // 
            // frmReporteVentasUsuarioEntreFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(708, 567);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "frmReporteVentasUsuarioEntreFechas";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Ventas entre fechas por Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteVentasUsuarioEntreFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private MetroFramework.Controls.MetroComboBox mcbUsuarios;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime mdtFinal;
        private MetroFramework.Controls.MetroDateTime mdtInicial;
        private MetroFramework.Controls.MetroButton mbExportar;
        private MetroFramework.Controls.MetroButton mbObtener;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpCollectionUsuarios;
    }
}