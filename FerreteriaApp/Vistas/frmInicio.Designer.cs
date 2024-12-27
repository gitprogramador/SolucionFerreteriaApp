namespace FerreteriaApp.Vistas
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentraEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteComptraEntreFechasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreVentasDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tsmiFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.tsmiFacturas});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1251, 89);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(98, 89);
            this.usuariosToolStripMenuItem.Text = "USUARIOS";
            this.usuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 89);
            this.clientesToolStripMenuItem.Text = "CLIENTES";
            this.clientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(129, 89);
            this.proveedoresToolStripMenuItem.Text = "PROVEEDORES";
            this.proveedoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(113, 89);
            this.categoriaToolStripMenuItem.Text = "CATEGORIAS";
            this.categoriaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(113, 89);
            this.productosToolStripMenuItem.Text = "PRODUCTOS";
            this.productosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compraToolStripMenuItem.Image")));
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(96, 89);
            this.compraToolStripMenuItem.Text = "COMPRAS";
            this.compraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaToolStripMenuItem.Image")));
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(78, 89);
            this.ventaToolStripMenuItem.Text = "VENTAS";
            this.ventaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBDToolStripMenuItem,
            this.restaurarBDToolStripMenuItem});
            this.operacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operacionesToolStripMenuItem.Image")));
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(126, 89);
            this.operacionesToolStripMenuItem.Text = "OPERACIONES";
            this.operacionesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // respaldarBDToolStripMenuItem
            // 
            this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
            this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.respaldarBDToolStripMenuItem.Text = "RESPALDAR BD";
            this.respaldarBDToolStripMenuItem.Click += new System.EventHandler(this.respaldarBDToolStripMenuItem_Click);
            // 
            // restaurarBDToolStripMenuItem
            // 
            this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
            this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.restaurarBDToolStripMenuItem.Text = "RESTAURAR BD";
            this.restaurarBDToolStripMenuItem.Click += new System.EventHandler(this.restaurarBDToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.ventasEntreFechasToolStripMenuItem,
            this.comprasEntreFechasToolStripMenuItem,
            this.cierreVentasDelDiaToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(95, 89);
            this.reportesToolStripMenuItem.Text = "REPORTES";
            this.reportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.inventarioToolStripMenuItem.Text = "INVENTARIO";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // ventasEntreFechasToolStripMenuItem
            // 
            this.ventasEntreFechasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVentraEntreFechasToolStripMenuItem,
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem});
            this.ventasEntreFechasToolStripMenuItem.Name = "ventasEntreFechasToolStripMenuItem";
            this.ventasEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.ventasEntreFechasToolStripMenuItem.Text = "VENTAS";
            // 
            // reporteVentraEntreFechasToolStripMenuItem
            // 
            this.reporteVentraEntreFechasToolStripMenuItem.Name = "reporteVentraEntreFechasToolStripMenuItem";
            this.reporteVentraEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reporteVentraEntreFechasToolStripMenuItem.Text = "Entre Fechas";
            this.reporteVentraEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.entreFechasToolStripMenuItem_Click);
            // 
            // reporteVentasPorUsuariosEntreFechasToolStripMenuItem
            // 
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem.Name = "reporteVentasPorUsuariosEntreFechasToolStripMenuItem";
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem.Text = "Por usuarios entre fechas";
            this.reporteVentasPorUsuariosEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.porUsuariosEntreFechasToolStripMenuItem_Click);
            // 
            // comprasEntreFechasToolStripMenuItem
            // 
            this.comprasEntreFechasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteComptraEntreFechasToolStripMenuItem1,
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem});
            this.comprasEntreFechasToolStripMenuItem.Name = "comprasEntreFechasToolStripMenuItem";
            this.comprasEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.comprasEntreFechasToolStripMenuItem.Text = "COMPRAS";
            // 
            // reporteComptraEntreFechasToolStripMenuItem1
            // 
            this.reporteComptraEntreFechasToolStripMenuItem1.Name = "reporteComptraEntreFechasToolStripMenuItem1";
            this.reporteComptraEntreFechasToolStripMenuItem1.Size = new System.Drawing.Size(292, 26);
            this.reporteComptraEntreFechasToolStripMenuItem1.Text = "ENTRE FECHAS";
            this.reporteComptraEntreFechasToolStripMenuItem1.Click += new System.EventHandler(this.eNTREFECHASToolStripMenuItem1_Click);
            // 
            // reporteComprasPorUsuarioEntreFechasToolStripMenuItem
            // 
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem.Name = "reporteComprasPorUsuarioEntreFechasToolStripMenuItem";
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem.Text = "POR USUARIO ENTRE FECHAS";
            this.reporteComprasPorUsuarioEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.pORUSUARIOENTREFECHASToolStripMenuItem_Click);
            // 
            // cierreVentasDelDiaToolStripMenuItem
            // 
            this.cierreVentasDelDiaToolStripMenuItem.Name = "cierreVentasDelDiaToolStripMenuItem";
            this.cierreVentasDelDiaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.cierreVentasDelDiaToolStripMenuItem.Text = "CIERRE/VENTAS DEL DIA";
            this.cierreVentasDelDiaToolStripMenuItem.Click += new System.EventHandler(this.cierreVentasDelDiaToolStripMenuItem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chartControl2);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(20, 149);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1251, 434);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartControl2
            // 
            this.chartControl2.Location = new System.Drawing.Point(627, 12);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(612, 410);
            this.chartControl2.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(611, 410);
            this.chartControl1.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1251, 434);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(615, 414);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chartControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(615, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(616, 414);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNombre});
            this.statusStrip1.Location = new System.Drawing.Point(20, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1251, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslNombre
            // 
            this.tsslNombre.Name = "tsslNombre";
            this.tsslNombre.Size = new System.Drawing.Size(118, 17);
            this.tsslNombre.Text = "toolStripStatusLabel1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngegg (1).png");
            this.imageList1.Images.SetKeyName(1, "pngegg (2).png");
            this.imageList1.Images.SetKeyName(2, "pngegg (3).png");
            this.imageList1.Images.SetKeyName(3, "pngegg (4).png");
            this.imageList1.Images.SetKeyName(4, "pngegg (5).png");
            this.imageList1.Images.SetKeyName(5, "pngegg (6).png");
            this.imageList1.Images.SetKeyName(6, "pngegg (7).png");
            this.imageList1.Images.SetKeyName(7, "pngegg.png");
            // 
            // tsmiFacturas
            // 
            this.tsmiFacturas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFacturas.Image")));
            this.tsmiFacturas.Name = "tsmiFacturas";
            this.tsmiFacturas.Size = new System.Drawing.Size(97, 89);
            this.tsmiFacturas.Text = "FACTURAS";
            this.tsmiFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiFacturas.Click += new System.EventHandler(this.tsmiFacturas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1291, 625);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Resizable = false;
            this.Text = "DASHBOARD";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNombre;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentraEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasPorUsuariosEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteComptraEntreFechasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteComprasPorUsuarioEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreVentasDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacturas;
    }
}