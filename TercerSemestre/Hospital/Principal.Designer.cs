namespace Hospital
{
    partial class Principal
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayorOMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promedioToolStripMenuItem,
            this.mayorOMenorToolStripMenuItem,
            this.factorialToolStripMenuItem,
            this.multiplicadorToolStripMenuItem,
            this.lista25ToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // promedioToolStripMenuItem
            // 
            this.promedioToolStripMenuItem.Name = "promedioToolStripMenuItem";
            this.promedioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promedioToolStripMenuItem.Text = "Promedio";
            this.promedioToolStripMenuItem.Click += new System.EventHandler(this.promedioToolStripMenuItem_Click);
            // 
            // mayorOMenorToolStripMenuItem
            // 
            this.mayorOMenorToolStripMenuItem.Name = "mayorOMenorToolStripMenuItem";
            this.mayorOMenorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mayorOMenorToolStripMenuItem.Text = "Mayor o menor";
            this.mayorOMenorToolStripMenuItem.Click += new System.EventHandler(this.mayorOMenorToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // multiplicadorToolStripMenuItem
            // 
            this.multiplicadorToolStripMenuItem.Name = "multiplicadorToolStripMenuItem";
            this.multiplicadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicadorToolStripMenuItem.Text = "Multiplicador";
            this.multiplicadorToolStripMenuItem.Click += new System.EventHandler(this.multiplicadorToolStripMenuItem_Click);
            // 
            // lista25ToolStripMenuItem
            // 
            this.lista25ToolStripMenuItem.Name = "lista25ToolStripMenuItem";
            this.lista25ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lista25ToolStripMenuItem.Text = "Lista 25";
            this.lista25ToolStripMenuItem.Click += new System.EventHandler(this.lista25ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayorOMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista25ToolStripMenuItem;
    }
}