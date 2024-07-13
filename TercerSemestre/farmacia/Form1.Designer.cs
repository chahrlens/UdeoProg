namespace farmacia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atlaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoFabricacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atlaDeProductosToolStripMenuItem,
            this.listaDeProductosToolStripMenuItem,
            this.rangoFabricacionToolStripMenuItem,
            this.vencimientosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // atlaDeProductosToolStripMenuItem
            // 
            this.atlaDeProductosToolStripMenuItem.Name = "atlaDeProductosToolStripMenuItem";
            this.atlaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.atlaDeProductosToolStripMenuItem.Text = "Atla de productos";
            this.atlaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.atlaDeProductosToolStripMenuItem_Click);
            // 
            // listaDeProductosToolStripMenuItem
            // 
            this.listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            this.listaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeProductosToolStripMenuItem.Text = "Existencias";
            this.listaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listaDeProductosToolStripMenuItem_Click);
            // 
            // rangoFabricacionToolStripMenuItem
            // 
            this.rangoFabricacionToolStripMenuItem.Name = "rangoFabricacionToolStripMenuItem";
            this.rangoFabricacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rangoFabricacionToolStripMenuItem.Text = "Rango fabricacion";
            this.rangoFabricacionToolStripMenuItem.Click += new System.EventHandler(this.rangoFabricacionToolStripMenuItem_Click);
            // 
            // vencimientosToolStripMenuItem
            // 
            this.vencimientosToolStripMenuItem.Name = "vencimientosToolStripMenuItem";
            this.vencimientosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vencimientosToolStripMenuItem.Text = "Vencimientos";
            this.vencimientosToolStripMenuItem.Click += new System.EventHandler(this.vencimientosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atlaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoFabricacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencimientosToolStripMenuItem;
    }
}

